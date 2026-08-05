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
		[Cpp2IlInjected.Address(RVA = "0x67FB40", Offset = "0x67EB40", VA = "0x18067FB40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6121ED0", Offset = "0x6120ED0", VA = "0x186121ED0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6996F0", Offset = "0x6986F0", VA = "0x1806996F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F8000", Offset = "0x7F7000", VA = "0x1807F8000")]
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
	[Cpp2IlInjected.Address(RVA = "0x851A00", Offset = "0x850A00", VA = "0x180851A00")]
	public EPHGAHCJANN(params IDisposable[] ANHIDLFDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xD77A00", Offset = "0xD76A00", VA = "0x180D77A00")]
	public static EPHGAHCJANN DHGKFEMNGCO(params IDisposable[] ANHIDLFDNAP)
	{
		return default(EPHGAHCJANN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6121D40", Offset = "0x6120D40", VA = "0x186121D40", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x2858E50", Offset = "0x2857E50", VA = "0x182858E50")]
	public AHCAMPNNFND(IDisposable KKBMLPHFFPJ, in T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A84540", Offset = "0x2A83540", VA = "0x182A84540")]
	public static global::AHCAMPNNFND<U> GGIJGLKFFJE<U>(in global::AHCAMPNNFND<T> KKBMLPHFFPJ, in U DFEOJBAFBHE)
	{
		return default(global::AHCAMPNNFND<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2962A60", Offset = "0x2961A60", VA = "0x182962A60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class IJJBFCFBNOB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x28B7020", Offset = "0x28B6020", VA = "0x1828B7020")]
	public static global::AHCAMPNNFND<T> DHGKFEMNGCO<T>(IDisposable KKBMLPHFFPJ, in T DFEOJBAFBHE)
	{
		return default(global::AHCAMPNNFND<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2784AA0", Offset = "0x2783AA0", VA = "0x182784AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00")]
	public static PECDMMMIOEE GNCNGCOCOBN(Type IGEIBCJNCHF, [Optional] string INGPIBINEEO, [Optional] string KGFFPLPLJIC, bool HKKGCHFHJIJ = false)
	{
		return default(PECDMMMIOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x681D00", Offset = "0x680D00", VA = "0x180681D00")]
	public static PECDMMMIOEE GNCNGCOCOBN<T>([Optional] string INGPIBINEEO, [Optional] string KGFFPLPLJIC, bool HKKGCHFHJIJ = false)
	{
		return default(PECDMMMIOEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6121C60", Offset = "0x6120C60", VA = "0x186121C60")]
	protected AAHLPJGCFPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string HDMGCOABJMF();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6121860", Offset = "0x6120860", VA = "0x186121860", Slot = "6")]
	public virtual string IKNMLAPIDJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61219E0", Offset = "0x61209E0", VA = "0x1861219E0")]
	public void OCEGKHBMEPG(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61218E0", Offset = "0x61208E0", VA = "0x1861218E0")]
	public void KHNJOLAEEEC(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61216F0", Offset = "0x61206F0", VA = "0x1861216F0")]
	public void HEKICKHKDHA(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6121600", Offset = "0x6120600", VA = "0x186121600")]
	public void COMMKGAFPGN(StringBuilder FMGHJPGOLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6121940", Offset = "0x6120940", VA = "0x186121940")]
	public static void LMJMDLKIADO(StringBuilder FMGHJPGOLOC, string GMLNFHEPDEM, string LGBCEEBCGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x685670", Offset = "0x684670", VA = "0x180685670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CPGFADKEOAF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6121CD0", Offset = "0x6120CD0", VA = "0x186121CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2DF7250", Offset = "0x2DF6250", VA = "0x182DF7250")]
	private FKOPOOLJMKP(in TErr EFMNEHKPBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2DF7180", Offset = "0x2DF6180", VA = "0x182DF7180")]
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
	[Cpp2IlInjected.Address(RVA = "0x6121E60", Offset = "0x6120E60", VA = "0x186121E60")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D87580", Offset = "0x2D86580", VA = "0x182D87580")]
	private PHDFHNMCEPC(in TOk HIDBMMPDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2012C40", Offset = "0x2011C40", VA = "0x182012C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x3EADF70", Offset = "0x3EACF70", VA = "0x183EADF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BPMGOAOFOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE820", Offset = "0x3EAD820", VA = "0x183EAE820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3EB0190", Offset = "0x3EAF190", VA = "0x183EB0190")]
	internal CIOEKKBILIB(in TErr EFMNEHKPBKH, in TOk HIDBMMPDOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3EAEBB0", Offset = "0x3EADBB0", VA = "0x183EAEBB0")]
	public static global::CIOEKKBILIB<TOk, TErr> OLIENIHJOOB(in TErr EFMNEHKPBKH)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD100", Offset = "0x3EAC100", VA = "0x183EAD100")]
	public static global::CIOEKKBILIB<TOk, TErr> GAIMEONOBEK(in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E6D3B0", Offset = "0x1E6C3B0", VA = "0x181E6D3B0")]
	public global::CIOEKKBILIB<TOk, UErr> FKAIFGCIOMI<UErr>()
	{
		return default(global::CIOEKKBILIB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E6E230", Offset = "0x1E6D230", VA = "0x181E6E230")]
	public global::CIOEKKBILIB<UOk, TErr> PDABIFMFAIA<UOk>()
	{
		return default(global::CIOEKKBILIB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DE70", Offset = "0x1E6CE70", VA = "0x181E6DE70")]
	public global::CIOEKKBILIB<UOk, TErr> KENAIHCHAFH<UOk>()
	{
		return default(global::CIOEKKBILIB<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E6DB00", Offset = "0x1E6CB00", VA = "0x181E6DB00")]
	public global::CIOEKKBILIB<TOk, UErr> GAMGPIKMLDF<UErr>()
	{
		return default(global::CIOEKKBILIB<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB000", Offset = "0x3EAA000", VA = "0x183EAB000")]
	public global::CIOEKKBILIB<PEFLLNEDEOA, TErr> EHDHNEJBIII()
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3EACDD0", Offset = "0x3EABDD0", VA = "0x183EACDD0")]
	public static bool FHCNBCDBOFI(in global::CIOEKKBILIB<TOk, TErr> LKPNMPOCKEL, in global::CIOEKKBILIB<TOk, TErr> JJHFBCIJNFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB200", Offset = "0x3EAA200", VA = "0x183EAB200", Slot = "4")]
	public bool Equals(global::CIOEKKBILIB<TOk, TErr> KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3EAB340", Offset = "0x3EAA340", VA = "0x183EAB340", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD890", Offset = "0x3EAC890", VA = "0x183EAD890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3EAFAF0", Offset = "0x3EAEAF0", VA = "0x183EAFAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ENLLBGEBECG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x395CA00", Offset = "0x395BA00", VA = "0x18395CA00")]
	public static global::CIOEKKBILIB<TOk, TErr> MHBMKCOIGAJ<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x395D550", Offset = "0x395C550", VA = "0x18395D550")]
	public static global::CIOEKKBILIB<PEFLLNEDEOA, TErr> MHBMKCOIGAJ<TErr>(this in global::CIOEKKBILIB<PEFLLNEDEOA, TErr> BLHHJNENDMO)
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x395CA30", Offset = "0x395BA30", VA = "0x18395CA30")]
	public static global::CIOEKKBILIB<TOk, TErr> BEIHAAAMLFG<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in TErr EFMNEHKPBKH)
	{
		return default(global::CIOEKKBILIB<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x395D1D0", Offset = "0x395C1D0", VA = "0x18395D1D0")]
	public static TOk FPJDOIDDACC<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x395C8D0", Offset = "0x395B8D0", VA = "0x18395C8D0")]
	[AsyncStateMachine(typeof(HJPJJBIFGFJ))]
	public static Task<TOk> BDKMMAPICCA<TOk, TErr>(this Task<global::CIOEKKBILIB<TOk, TErr>> BLHHJNENDMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x395CF20", Offset = "0x395BF20", VA = "0x18395CF20")]
	public static TErr DALHIAFFGGM<TErr, TOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x395D720", Offset = "0x395C720", VA = "0x18395D720")]
	public static bool MLKMHOJGLNH<TOk, TErr, UErr, UOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out global::CIOEKKBILIB<UOk, UErr> OLDPJMFNFIH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x395CEE0", Offset = "0x395BEE0", VA = "0x18395CEE0")]
	public static bool CIJPMOLKFLM<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x395D580", Offset = "0x395C580", VA = "0x18395D580")]
	public static bool MIHPFBBIFKP<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TErr EFMNEHKPBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x395E1B0", Offset = "0x395D1B0", VA = "0x18395E1B0")]
	public static bool PJNHCOECNLC<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out TErr EFMNEHKPBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x395D240", Offset = "0x395C240", VA = "0x18395D240")]
	public static bool GAGEKOOIFML<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<TOk, TErr> OLDPJMFNFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x395DBD0", Offset = "0x395CBD0", VA = "0x18395DBD0")]
	public static bool MLKMHOJGLNH<TOk, TErr, UErr, UOk>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<UOk, UErr> OLDPJMFNFIH) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x395CBE0", Offset = "0x395BBE0", VA = "0x18395CBE0")]
	public static bool CIJFHGCIPLB<TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, out TOk HIDBMMPDOFF, out global::CIOEKKBILIB<PEFLLNEDEOA, TErr> OLDPJMFNFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x395DE70", Offset = "0x395CE70", VA = "0x18395DE70")]
	public static global::CIOEKKBILIB<UOk, UErr> NBONNFLDBAP<UOk, UErr, TOk, TErr>(this in global::CIOEKKBILIB<TOk, TErr> BLHHJNENDMO, in global::CIOEKKBILIB<UOk, UErr> GJBHFPJIHBB) where TOk : UOk where TErr : UErr
	{
		return default(global::CIOEKKBILIB<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x395D2A0", Offset = "0x395C2A0", VA = "0x18395D2A0")]
	public static global::CIOEKKBILIB<TOk[], TErr> HPKAHHCELPH<TOk, TErr>(this IEnumerable<global::CIOEKKBILIB<TOk, TErr>> BLHHJNENDMO)
	{
		return default(global::CIOEKKBILIB<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1F61820", Offset = "0x1F60820", VA = "0x181F61820")]
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
	[Cpp2IlInjected.Address(RVA = "0x26CD480", Offset = "0x26CC480", VA = "0x1826CD480")]
	public static global::CIOEKKBILIB<TOk, T> MHBMKCOIGAJ<TOk>(in TOk HIDBMMPDOFF)
	{
		return default(global::CIOEKKBILIB<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24C7930", Offset = "0x24C6930", VA = "0x1824C7930")]
	public static global::CIOEKKBILIB<PEFLLNEDEOA, T> MHBMKCOIGAJ()
	{
		return default(global::CIOEKKBILIB<PEFLLNEDEOA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26CD540", Offset = "0x26CC540", VA = "0x1826CD540")]
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
		[Cpp2IlInjected.Address(RVA = "0x2F8B470", Offset = "0x2F8A470", VA = "0x182F8B470")]
		public AKOLLFOMNCC(global::IBJMPLCENIK<T> APDEKDBFHJE, int NLJMAKJGGAO, bool PDOOFOCADKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B340", Offset = "0x2F8A340", VA = "0x182F8B340")]
		public global::IBJMPLCENIK<T>.EPEJEGNOIAG HPPJKDPBNFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B430", Offset = "0x2F8A430", VA = "0x182F8B430", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2F8B430", Offset = "0x2F8A430", VA = "0x182F8B430", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x20188B0", Offset = "0x20178B0", VA = "0x1820188B0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2018A40", Offset = "0x2017A40", VA = "0x182018A40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x2018BF0", Offset = "0x2017BF0", VA = "0x182018BF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2019220", Offset = "0x2018220", VA = "0x182019220")]
		public EPEJEGNOIAG(global::IBJMPLCENIK<T> APDEKDBFHJE, int NLJMAKJGGAO, bool PDOOFOCADKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x20189A0", Offset = "0x20179A0", VA = "0x1820189A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x2018A20", Offset = "0x2017A20", VA = "0x182018A20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "5")]
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
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6402B0", Offset = "0x63F6B0")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x13D8310", Offset = "0x13D7310", VA = "0x1813D8310")]
		public PKFCMJJJNEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2D8E330", Offset = "0x2D8D330", VA = "0x182D8E330")]
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
		[Cpp2IlInjected.Address(RVA = "0x4524D80", Offset = "0x4523D80", VA = "0x184524D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T JLIFGAJEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x23A93C0", Offset = "0x23A83C0", VA = "0x1823A93C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T DEAMFGIIJDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x45250A0", Offset = "0x45240A0", VA = "0x1845250A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4524E50", Offset = "0x4523E50", VA = "0x184524E50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AFMNPELKBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84EE40", Offset = "0x84DE40", VA = "0x18084EE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x45250D0", Offset = "0x45240D0", VA = "0x1845250D0")]
	private static int LABEIDIDGOE(int NPDGHPHAKDK, int MFAHIHFAKKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x45250F0", Offset = "0x45240F0", VA = "0x1845250F0")]
	public IBJMPLCENIK(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4525200", Offset = "0x4524200", VA = "0x184525200")]
	public IBJMPLCENIK(int BDHBBDMMOKG, Func<T> JKHBIKMOIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4525470", Offset = "0x4524470", VA = "0x184525470")]
	public IBJMPLCENIK(T[] ANHIDLFDNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4524DC0", Offset = "0x4523DC0", VA = "0x184524DC0")]
	public void BEGHAIBIKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4524F70", Offset = "0x4523F70", VA = "0x184524F70")]
	public IEnumerable<T> DJEHCDPHOKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4525020", Offset = "0x4524020", VA = "0x184525020")]
	public global::IBJMPLCENIK<T>.EPEJEGNOIAG HPPJKDPBNFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EF10", Offset = "0x1E6DF10", VA = "0x181E6EF10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1E6EF10", Offset = "0x1E6DF10", VA = "0x181E6EF10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class EKHOMMNOOCF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x395BD60", Offset = "0x395AD60", VA = "0x18395BD60")]
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
	[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "5")]
	public override string HDMGCOABJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x374FAF0", Offset = "0x374EAF0", VA = "0x18374FAF0")]
	internal BCGOCAIFDEM(string LMLMHJKGDCH, in TData FILAKGLBGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PNCFOJKGEGF
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6121F60", Offset = "0x6120F60", VA = "0x186121F60")]
	public static global::BCGOCAIFDEM<PEFLLNEDEOA> DHGKFEMNGCO(string LMLMHJKGDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x22DC010", Offset = "0x22DB010", VA = "0x1822DC010")]
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
