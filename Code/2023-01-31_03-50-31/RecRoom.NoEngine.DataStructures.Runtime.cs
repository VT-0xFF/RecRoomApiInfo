using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x87E940", Offset = "0x87D740", VA = "0x18087E940")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63A4F00", Offset = "0x63A3D00", VA = "0x1863A4F00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x922590", Offset = "0x921390", VA = "0x180922590")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x11E9610", Offset = "0x11E8410", VA = "0x1811E9610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EDADGPFLFBI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface CNBFOIHCKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DNOMJEHFCNH(string BBOEMCCPBPO);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NIBCFDKIMOM(string BDICMGNPCMC);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LAEJNLMKBEM(Exception ILBPMKLBBAG);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static CNBFOIHCKPA JKCIDAEDHPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EPHGAHCJANN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] CECPFOHLIJJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DE0", Offset = "0x6AFBE0", VA = "0x1806B0DE0")]
	public EPHGAHCJANN(params IDisposable[] ANHIDLFDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B0DC0", Offset = "0x6AFBC0", VA = "0x1806B0DC0")]
	public static EPHGAHCJANN DHGKFEMNGCO(params IDisposable[] ANHIDLFDNAP)
	{
		return default(EPHGAHCJANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x63A4D70", Offset = "0x63A3B70", VA = "0x1863A4D70", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AHCAMPNNFND<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable KHDANJBAKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T FBCEGMCNEND;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6410", Offset = "0x3FF5210", VA = "0x183FF6410")]
	public AHCAMPNNFND(IDisposable KKBMLPHFFPJ, in T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3E24070", Offset = "0x3E22E70", VA = "0x183E24070")]
	public static global::AHCAMPNNFND<U> GGIJGLKFFJE<U>(in global::AHCAMPNNFND<T> KKBMLPHFFPJ, in U DFEOJBAFBHE)
	{
		return default(global::AHCAMPNNFND<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3FF6370", Offset = "0x3FF5170", VA = "0x183FF6370", Slot = "4")]
	public readonly void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IJJBFCFBNOB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36A2DD0", Offset = "0x36A1BD0", VA = "0x1836A2DD0")]
	public static global::AHCAMPNNFND<T> DHGKFEMNGCO<T>(IDisposable KKBMLPHFFPJ, in T DFEOJBAFBHE)
	{
		return default(global::AHCAMPNNFND<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x33C5100", Offset = "0x33C3F00", VA = "0x1833C5100")]
	public static global::AHCAMPNNFND<U> GGIJGLKFFJE<U, T>(in global::AHCAMPNNFND<T> HEFOHOLIMPM, in U DFEOJBAFBHE)
	{
		return default(global::AHCAMPNNFND<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct PECDMMMIOEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00")]
	public static PECDMMMIOEE GNCNGCOCOBN(Type IGEIBCJNCHF, [Optional] string INGPIBINEEO, [Optional] string KGFFPLPLJIC, bool HKKGCHFHJIJ = false)
	{
		return default(PECDMMMIOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00")]
	public static PECDMMMIOEE GNCNGCOCOBN<T>([Optional] string INGPIBINEEO, [Optional] string KGFFPLPLJIC, bool HKKGCHFHJIJ = false)
	{
		return default(PECDMMMIOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class AAHLPJGCFPM
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool JCEJNDFGOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string OPJBOFCOFJI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual AAHLPJGCFPM FPHEDLEIDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B1800", Offset = "0x6B0600", VA = "0x1806B1800", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x63A4C90", Offset = "0x63A3A90", VA = "0x1863A4C90")]
	protected AAHLPJGCFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string HDMGCOABJMF();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63A4890", Offset = "0x63A3690", VA = "0x1863A4890", Slot = "6")]
	public virtual string IKNMLAPIDJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63A4A10", Offset = "0x63A3810", VA = "0x1863A4A10")]
	public void OCEGKHBMEPG(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63A4910", Offset = "0x63A3710", VA = "0x1863A4910")]
	public void KHNJOLAEEEC(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63A4720", Offset = "0x63A3520", VA = "0x1863A4720")]
	public void HEKICKHKDHA(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x63A4630", Offset = "0x63A3430", VA = "0x1863A4630")]
	public void COMMKGAFPGN(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63A4970", Offset = "0x63A3770", VA = "0x1863A4970")]
	public static void LMJMDLKIADO(StringBuilder FMGHJPGOLOC, string GMLNFHEPDEM, string LGBCEEBCGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8420D0", Offset = "0x840ED0", VA = "0x1808420D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CPGFADKEOAF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63A4D00", Offset = "0x63A3B00", VA = "0x1863A4D00")]
	public CPGFADKEOAF(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FKOPOOLJMKP<TErr> : CPGFADKEOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr BEIHAAAMLFG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0DF0", Offset = "0x3FCFBF0", VA = "0x183FD0DF0")]
	private FKOPOOLJMKP(in TErr EFMNEHKPBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3FD0D20", Offset = "0x3FCFB20", VA = "0x183FD0D20")]
	public static global::FKOPOOLJMKP<TErr> DHGKFEMNGCO(in TErr EFMNEHKPBKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PAAMOCEGACM<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OJNEELMJMOF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string LENGPBNLGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FEMCNPLNAHC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x63A4E90", Offset = "0x63A3C90", VA = "0x1863A4E90")]
	public FEMCNPLNAHC(string LMLMHJKGDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PHDFHNMCEPC<TOk> : FEMCNPLNAHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk MHBMKCOIGAJ;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x465F490", Offset = "0x465E290", VA = "0x18465F490")]
	private PHDFHNMCEPC(in TOk HIDBMMPDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2CCF160", Offset = "0x2CCDF60", VA = "0x182CCF160")]
	public static global::PHDFHNMCEPC<TOk> DHGKFEMNGCO(in TOk HIDBMMPDOFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct CIOEKKBILIB<TOk, TErr> : IEquatable<global::CIOEKKBILIB<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> OOHFLNNPCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr BEIHAAAMLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk MHBMKCOIGAJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PMACNAOFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x47DB110", Offset = "0x47D9F10", VA = "0x1847DB110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BPMGOAOFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x47DB9C0", Offset = "0x47DA7C0", VA = "0x1847DB9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x47DD330", Offset = "0x47DC130", VA = "0x1847DD330")]
	internal CIOEKKBILIB(in TErr EFMNEHKPBKH, in TOk HIDBMMPDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x47DBD50", Offset = "0x47DAB50", VA = "0x1847DBD50")]
	public static global::CIOEKKBILIB<TOk, TErr> OLIENIHJOOB(in TErr EFMNEHKPBKH)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x47DA2A0", Offset = "0x47D90A0", VA = "0x1847DA2A0")]
	public static global::CIOEKKBILIB<TOk, TErr> GAIMEONOBEK(in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2F5E620", Offset = "0x2F5D420", VA = "0x182F5E620")]
	public global::CIOEKKBILIB<TOk, UErr> FKAIFGCIOMI<UErr>()
	{
		return default(global::CIOEKKBILIB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F4A0", Offset = "0x2F5E2A0", VA = "0x182F5F4A0")]
	public global::CIOEKKBILIB<UOk, TErr> PDABIFMFAIA<UOk>()
	{
		return default(global::CIOEKKBILIB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2F5F0E0", Offset = "0x2F5DEE0", VA = "0x182F5F0E0")]
	public global::CIOEKKBILIB<UOk, TErr> KENAIHCHAFH<UOk>()
	{
		return default(global::CIOEKKBILIB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2F5ED70", Offset = "0x2F5DB70", VA = "0x182F5ED70")]
	public global::CIOEKKBILIB<TOk, UErr> GAMGPIKMLDF<UErr>()
	{
		return default(global::CIOEKKBILIB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x47D81A0", Offset = "0x47D6FA0", VA = "0x1847D81A0")]
	public global::CIOEKKBILIB<PEFLLNEDEOA, TErr> EHDHNEJBIII()
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47D9F70", Offset = "0x47D8D70", VA = "0x1847D9F70")]
	public static bool FHCNBCDBOFI(in global::CIOEKKBILIB<TOk, TErr> LKPNMPOCKEL, in global::CIOEKKBILIB<TOk, TErr> JJHFBCIJNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47D83A0", Offset = "0x47D71A0", VA = "0x1847D83A0", Slot = "4")]
	public bool Equals(global::CIOEKKBILIB<TOk, TErr> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47D84E0", Offset = "0x47D72E0", VA = "0x1847D84E0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x47DAA30", Offset = "0x47D9830", VA = "0x1847DAA30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x47DCC90", Offset = "0x47DBA90", VA = "0x1847DCC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ENLLBGEBECG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4077440", Offset = "0x4076240", VA = "0x184077440")]
	public static global::CIOEKKBILIB<TOk, TErr> MHBMKCOIGAJ<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4077F90", Offset = "0x4076D90", VA = "0x184077F90")]
	public static global::CIOEKKBILIB<PEFLLNEDEOA, TErr> MHBMKCOIGAJ<TErr>(this in global::CIOEKKBILIB<PEFLLNEDEOA, TErr> BLHHJNENDMO)
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4077470", Offset = "0x4076270", VA = "0x184077470")]
	public static global::CIOEKKBILIB<TOk, TErr> BEIHAAAMLFG<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in TErr EFMNEHKPBKH)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4077C10", Offset = "0x4076A10", VA = "0x184077C10")]
	public static TOk FPJDOIDDACC<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4077310", Offset = "0x4076110", VA = "0x184077310")]
	[AsyncStateMachine(typeof(HJPJJBIFGFJ))]
	public static Task<TOk> BDKMMAPICCA<TOk, TErr>(this Task<global::CIOEKKBILIB<TOk, TErr>> BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4077960", Offset = "0x4076760", VA = "0x184077960")]
	public static TErr DALHIAFFGGM<TErr, TOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4078160", Offset = "0x4076F60", VA = "0x184078160")]
	public static bool MLKMHOJGLNH<TOk, TErr, UErr, UOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out global::CIOEKKBILIB<UOk, UErr> OLDPJMFNFIH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4077920", Offset = "0x4076720", VA = "0x184077920")]
	public static bool CIJPMOLKFLM<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4077FC0", Offset = "0x4076DC0", VA = "0x184077FC0")]
	public static bool MIHPFBBIFKP<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TErr EFMNEHKPBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4078BF0", Offset = "0x40779F0", VA = "0x184078BF0")]
	public static bool PJNHCOECNLC<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out TErr EFMNEHKPBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4077C80", Offset = "0x4076A80", VA = "0x184077C80")]
	public static bool GAGEKOOIFML<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<TOk, TErr> OLDPJMFNFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4078610", Offset = "0x4077410", VA = "0x184078610")]
	public static bool MLKMHOJGLNH<TOk, TErr, UErr, UOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<UOk, UErr> OLDPJMFNFIH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4077620", Offset = "0x4076420", VA = "0x184077620")]
	public static bool CIJFHGCIPLB<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<PEFLLNEDEOA, TErr> OLDPJMFNFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x40788B0", Offset = "0x40776B0", VA = "0x1840788B0")]
	public static global::CIOEKKBILIB<UOk, UErr> NBONNFLDBAP<UOk, UErr, TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in global::CIOEKKBILIB<UOk, UErr> GJBHFPJIHBB) where TOk : UOk where TErr : UErr
	{
		return default(global::CIOEKKBILIB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4077CE0", Offset = "0x4076AE0", VA = "0x184077CE0")]
	public static global::CIOEKKBILIB<TOk[], TErr> HPKAHHCELPH<TOk, TErr>(this IEnumerable<global::CIOEKKBILIB<TOk, TErr>> BLHHJNENDMO)
	{
		return default(global::CIOEKKBILIB<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x35851C0", Offset = "0x3583FC0", VA = "0x1835851C0")]
	[IteratorStateMachine(typeof(HDDEFNEHLPI))]
	public static IEnumerable<TOk> MAIGPMHDEMA<TOk, TErr>(this IEnumerable<global::CIOEKKBILIB<TOk, TErr>> BLHHJNENDMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MKADOJLCKLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2F70D70", Offset = "0x2F6FB70", VA = "0x182F70D70")]
	public static global::CIOEKKBILIB<TOk, T> MHBMKCOIGAJ<TOk>(in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3821920", Offset = "0x3820720", VA = "0x183821920")]
	public static global::CIOEKKBILIB<PEFLLNEDEOA, T> MHBMKCOIGAJ()
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2F70E30", Offset = "0x2F6FC30", VA = "0x182F70E30")]
	public static global::CIOEKKBILIB<T, TErr> BEIHAAAMLFG<TErr>(in TErr EFMNEHKPBKH)
	{
		return default(global::CIOEKKBILIB<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class IBJMPLCENIK<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct AKOLLFOMNCC : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::IBJMPLCENIK<T> ICDPFHMLIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int DPMOMKLKOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool PPBFIDEPHNK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1544040", Offset = "0x1542E40", VA = "0x181544040")]
		public AKOLLFOMNCC(global::IBJMPLCENIK<T> APDEKDBFHJE, int NLJMAKJGGAO, bool PDOOFOCADKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4002B90", Offset = "0x4001990", VA = "0x184002B90")]
		public global::IBJMPLCENIK<T>.EPEJEGNOIAG HPPJKDPBNFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4002C80", Offset = "0x4001A80", VA = "0x184002C80", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4002C80", Offset = "0x4001A80", VA = "0x184002C80", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class EPEJEGNOIAG : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::IBJMPLCENIK<T> ICDPFHMLIAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int LODCNEKJNJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int AFBOOPDLHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool PPBFIDEPHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool AMPKEBPCAGM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2CD55A0", Offset = "0x2CD43A0", VA = "0x182CD55A0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2CD5730", Offset = "0x2CD4530", VA = "0x182CD5730", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2CD58E0", Offset = "0x2CD46E0", VA = "0x182CD58E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5F10", Offset = "0x2CD4D10", VA = "0x182CD5F10")]
		public EPEJEGNOIAG(global::IBJMPLCENIK<T> APDEKDBFHJE, int NLJMAKJGGAO, bool PDOOFOCADKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5690", Offset = "0x2CD4490", VA = "0x182CD5690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2CD5710", Offset = "0x2CD4510", VA = "0x182CD5710", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PKFCMJJJNEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x676C20", Offset = "0x676020")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public PKFCMJJJNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4666840", Offset = "0x4665640", VA = "0x184666840")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] ANDCNKFCEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int AFBOOPDLHPN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IBNJNCPFKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5056EA0", Offset = "0x5055CA0", VA = "0x185056EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T JLIFGAJEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37C42C0", Offset = "0x37C30C0", VA = "0x1837C42C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DEAMFGIIJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50571C0", Offset = "0x5055FC0", VA = "0x1850571C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5056F70", Offset = "0x5055D70", VA = "0x185056F70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAF6210", Offset = "0xAF5010", VA = "0x180AF6210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x50571F0", Offset = "0x5055FF0", VA = "0x1850571F0")]
	private static int LABEIDIDGOE(int NPDGHPHAKDK, int MFAHIHFAKKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5057210", Offset = "0x5056010", VA = "0x185057210")]
	public IBJMPLCENIK(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5057320", Offset = "0x5056120", VA = "0x185057320")]
	public IBJMPLCENIK(int BDHBBDMMOKG, Func<T> JKHBIKMOIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5057590", Offset = "0x5056390", VA = "0x185057590")]
	public IBJMPLCENIK(T[] ANHIDLFDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5056EE0", Offset = "0x5055CE0", VA = "0x185056EE0")]
	public void BEGHAIBIKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5057090", Offset = "0x5055E90", VA = "0x185057090")]
	public IEnumerable<T> DJEHCDPHOKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5057140", Offset = "0x5055F40", VA = "0x185057140")]
	public global::IBJMPLCENIK<T>.EPEJEGNOIAG HPPJKDPBNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2F60250", Offset = "0x2F5F050", VA = "0x182F60250", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2F60250", Offset = "0x2F5F050", VA = "0x182F60250", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EKHOMMNOOCF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x40765C0", Offset = "0x40753C0", VA = "0x1840765C0")]
	public static global::IBJMPLCENIK<T> DHGKFEMNGCO<T>(int BDHBBDMMOKG, Func<T> JKHBIKMOIGL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class BCGOCAIFDEM<TData> : AAHLPJGCFPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string ONMBFCNACCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData BJEGJENJPJG;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
	public override string HDMGCOABJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4F40870", Offset = "0x4F3F670", VA = "0x184F40870")]
	internal BCGOCAIFDEM(string LMLMHJKGDCH, in TData FILAKGLBGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PNCFOJKGEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63A4F90", Offset = "0x63A3D90", VA = "0x1863A4F90")]
	public static global::BCGOCAIFDEM<PEFLLNEDEOA> DHGKFEMNGCO(string LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x33E4BA0", Offset = "0x33E39A0", VA = "0x1833E4BA0")]
	public static global::BCGOCAIFDEM<TData> DHGKFEMNGCO<TData>(string LMLMHJKGDCH, in TData FILAKGLBGGA)
	{
		return null;
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
