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
		[Cpp2IlInjected.Address(RVA = "0x6B6780", Offset = "0x6B5380", VA = "0x1806B6780")]
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
		[Cpp2IlInjected.Address(RVA = "0x609DEC0", Offset = "0x609CAC0", VA = "0x18609DEC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBD0", Offset = "0x6DD7D0", VA = "0x1806DEBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB37F50", Offset = "0xB36B50", VA = "0x180B37F50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CBFKDACELHG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface PPEONIKNNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string LAKJFLEAAFA(string EELLMKKFNIC);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DJEAOKOFLJM(string NOGJKHDOHIA);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LEDHDAHMEKA(Exception CFGIDIAFBCD);
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static PPEONIKNNMA OHEGMANNBEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MMIOFAJKLFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IDisposable[] MGMPLPLAIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x695F00", Offset = "0x694B00", VA = "0x180695F00")]
	public MMIOFAJKLFK(params IDisposable[] BPLLJKNAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DDB40", Offset = "0x6DC740", VA = "0x1806DDB40")]
	public static MMIOFAJKLFK GADFBDMBHED(params IDisposable[] BPLLJKNAEBK)
	{
		return default(MMIOFAJKLFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x609DDA0", Offset = "0x609C9A0", VA = "0x18609DDA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CBAMOJBAPMI<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IDisposable GBDDNDOCCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public T FGHAAIAMOAB;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3470200", Offset = "0x346EE00", VA = "0x183470200")]
	public CBAMOJBAPMI(IDisposable DGIABMCLHLD, in T NENFOEKGNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A35900", Offset = "0x2A34500", VA = "0x182A35900")]
	public static global::CBAMOJBAPMI<U> NKMCIADCFLO<U>(in global::CBAMOJBAPMI<T> DGIABMCLHLD, in U NENFOEKGNGK)
	{
		return default(global::CBAMOJBAPMI<U>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC290", Offset = "0x3BEAE90", VA = "0x183BEC290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class ELHLKPDEIOH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2809980", Offset = "0x2808580", VA = "0x182809980")]
	public static global::CBAMOJBAPMI<T> GADFBDMBHED<T>(IDisposable DGIABMCLHLD, in T NENFOEKGNGK)
	{
		return default(global::CBAMOJBAPMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x28099B0", Offset = "0x28085B0", VA = "0x1828099B0")]
	public static global::CBAMOJBAPMI<U> NKMCIADCFLO<U, T>(in global::CBAMOJBAPMI<T> CPJCABKKNLJ, in U NENFOEKGNGK)
	{
		return default(global::CBAMOJBAPMI<U>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct MMMAHAOIEJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0")]
	public static MMMAHAOIEJM ENBHIILOAJE(Type JMPEGNOKOOB, [Optional] string FEPBEADIELH, [Optional] string PCNIDIAFJCK, bool LNBKNILNHJL = false)
	{
		return default(MMMAHAOIEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0")]
	public static MMMAHAOIEJM ENBHIILOAJE<T>([Optional] string FEPBEADIELH, [Optional] string PCNIDIAFJCK, bool LNBKNILNHJL = false)
	{
		return default(MMMAHAOIEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class DLGHCKKHLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static bool FGKGDJPKFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly string DCPGFNFHKFA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public virtual DLGHCKKHLGP DJNMKGIMAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6AD8D0", Offset = "0x6AC4D0", VA = "0x1806AD8D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x609DD30", Offset = "0x609C930", VA = "0x18609DD30")]
	protected DLGHCKKHLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string NEIJODKECBL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x609DBB0", Offset = "0x609C7B0", VA = "0x18609DBB0", Slot = "6")]
	public virtual string KHJGEKFBPIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x609D7C0", Offset = "0x609C3C0", VA = "0x18609D7C0")]
	public void GMEMNBCHCIA(StringBuilder LOBJNHKLLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x609DC30", Offset = "0x609C830", VA = "0x18609DC30")]
	public void LGKBBCLKFCG(StringBuilder LOBJNHKLLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x609DA40", Offset = "0x609C640", VA = "0x18609DA40")]
	public void JDPPIJOHKML(StringBuilder LOBJNHKLLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x609D6D0", Offset = "0x609C2D0", VA = "0x18609D6D0")]
	public void GLFGEKNPCAB(StringBuilder LOBJNHKLLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x609DC90", Offset = "0x609C890", VA = "0x18609DC90")]
	public static void NNFNDOJNLAJ(StringBuilder LOBJNHKLLCH, string LBONDKPAKCM, string NPIBCDLIGLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x73AA30", Offset = "0x739630", VA = "0x18073AA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PAABNCJKKKB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x609DF50", Offset = "0x609CB50", VA = "0x18609DF50")]
	public PAABNCJKKKB(string DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BFCIBFINJJD<TErr> : PAABNCJKKKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly TErr BCKPFLCBBEL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x369A270", Offset = "0x3698E70", VA = "0x18369A270")]
	private BFCIBFINJJD(in TErr FLGIAEBOFMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x369A1A0", Offset = "0x3698DA0", VA = "0x18369A1A0")]
	public static global::BFCIBFINJJD<TErr> GADFBDMBHED(in TErr FLGIAEBOFMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CLFEJKCCEGN<out TOptions>
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	TOptions FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HJJILPJDFFA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	string JOPJKOAIICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DJMDGOGPBDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x609D660", Offset = "0x609C260", VA = "0x18609D660")]
	public DJMDGOGPBDC(string DPNJMDFICMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DCPBCPIPLAB<TOk> : DJMDGOGPBDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly TOk HCLIDEODMNH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2D805B0", Offset = "0x2D7F1B0", VA = "0x182D805B0")]
	private DCPBCPIPLAB(in TOk LDEKLNNPEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C47E50", Offset = "0x2C46A50", VA = "0x182C47E50")]
	public static global::DCPBCPIPLAB<TOk> GADFBDMBHED(in TOk LDEKLNNPEJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct DGDFIFNFPJI<TOk, TErr> : IEquatable<global::DGDFIFNFPJI<TOk, TErr>>
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly EqualityComparer<TErr> GCPOAACFAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly TErr BCKPFLCBBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly TOk HCLIDEODMNH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IJGJPFAKGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2D95420", Offset = "0x2D94020", VA = "0x182D95420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool JDLPJHCDHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2D94E60", Offset = "0x2D93A60", VA = "0x182D94E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2D97170", Offset = "0x2D95D70", VA = "0x182D97170")]
	internal DGDFIFNFPJI(in TErr FLGIAEBOFMA, in TOk LDEKLNNPEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2D927A0", Offset = "0x2D913A0", VA = "0x182D927A0")]
	public static global::DGDFIFNFPJI<TOk, TErr> EHPEFOJKJPD(in TErr FLGIAEBOFMA)
	{
		return default(global::DGDFIFNFPJI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2D95280", Offset = "0x2D93E80", VA = "0x182D95280")]
	public static global::DGDFIFNFPJI<TOk, TErr> KBELOPNOOOL(in TOk LDEKLNNPEJO)
	{
		return default(global::DGDFIFNFPJI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A37610", Offset = "0x2A36210", VA = "0x182A37610")]
	public global::DGDFIFNFPJI<TOk, UErr> PFMFCKJKNHF<UErr>()
	{
		return default(global::DGDFIFNFPJI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A373A0", Offset = "0x2A35FA0", VA = "0x182A373A0")]
	public global::DGDFIFNFPJI<UOk, TErr> IBDDEEBGJJG<UOk>()
	{
		return default(global::DGDFIFNFPJI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A36FE0", Offset = "0x2A35BE0", VA = "0x182A36FE0")]
	public global::DGDFIFNFPJI<UOk, TErr> BHMKNBBONLK<UOk>()
	{
		return default(global::DGDFIFNFPJI<UOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A37540", Offset = "0x2A36140", VA = "0x182A37540")]
	public global::DGDFIFNFPJI<TOk, UErr> MKBFMEOAAFL<UErr>()
	{
		return default(global::DGDFIFNFPJI<TOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2D95EA0", Offset = "0x2D94AA0", VA = "0x182D95EA0")]
	public global::DGDFIFNFPJI<CJFIGKJMGNA, TErr> LHJLBPCHODF()
	{
		return default(global::DGDFIFNFPJI<CJFIGKJMGNA, TErr>);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2D946D0", Offset = "0x2D932D0", VA = "0x182D946D0")]
	public static bool HIPCOIHOPDI(in global::DGDFIFNFPJI<TOk, TErr> FLCFFJEGIJG, in global::DGDFIFNFPJI<TOk, TErr> DCMBMJJNKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D92C10", Offset = "0x2D91810", VA = "0x182D92C10", Slot = "4")]
	public bool Equals(global::DGDFIFNFPJI<TOk, TErr> GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D92A20", Offset = "0x2D91620", VA = "0x182D92A20", Slot = "0")]
	public override bool Equals(object GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2D93F20", Offset = "0x2D92B20", VA = "0x182D93F20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2D96B90", Offset = "0x2D95790", VA = "0x182D96B90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EHNMIOLHKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A70", Offset = "0x2CA7670", VA = "0x182CA8A70")]
	public static global::DGDFIFNFPJI<TOk, TErr> HCLIDEODMNH<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, in TOk LDEKLNNPEJO)
	{
		return default(global::DGDFIFNFPJI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8E00", Offset = "0x2CA7A00", VA = "0x182CA8E00")]
	public static global::DGDFIFNFPJI<CJFIGKJMGNA, TErr> HCLIDEODMNH<TErr>(this in global::DGDFIFNFPJI<CJFIGKJMGNA, TErr> JELCPGCJLIH)
	{
		return default(global::DGDFIFNFPJI<CJFIGKJMGNA, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A70", Offset = "0x2CA7670", VA = "0x182CA8A70")]
	public static global::DGDFIFNFPJI<TOk, TErr> BCKPFLCBBEL<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, in TErr FLGIAEBOFMA)
	{
		return default(global::DGDFIFNFPJI<TOk, TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA3C0", Offset = "0x2CA8FC0", VA = "0x182CAA3C0")]
	public static TOk NHEPEMKOIDO<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH)
	{
		return (TOk)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8BA0", Offset = "0x2CA77A0", VA = "0x182CA8BA0")]
	[AsyncStateMachine(typeof(APACMMOGNMO))]
	public static Task<TOk> GKJEHGFIFOK<TOk, TErr>(this Task<global::DGDFIFNFPJI<TOk, TErr>> JELCPGCJLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8E30", Offset = "0x2CA7A30", VA = "0x182CA8E30")]
	public static TErr HMJDABCINDA<TErr, TOk>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH)
	{
		return (TErr)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9C00", Offset = "0x2CA8800", VA = "0x182CA9C00")]
	public static bool MJBJFFOPBBJ<TOk, TErr, UErr, UOk>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out global::DGDFIFNFPJI<UOk, UErr> NHGLMJBPNPN) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2CA92E0", Offset = "0x2CA7EE0", VA = "0x182CA92E0")]
	public static bool IOJKHADJJFB<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TOk LDEKLNNPEJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9A60", Offset = "0x2CA8660", VA = "0x182CA9A60")]
	public static bool LEALBELCIGC<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TErr FLGIAEBOFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9A00", Offset = "0x2CA8600", VA = "0x182CA9A00")]
	public static bool KECEBFJKEGJ<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TOk LDEKLNNPEJO, out TErr FLGIAEBOFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8B40", Offset = "0x2CA7740", VA = "0x182CA8B40")]
	public static bool EFLPEHJNJIH<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TOk LDEKLNNPEJO, out global::DGDFIFNFPJI<TOk, TErr> NHGLMJBPNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA0B0", Offset = "0x2CA8CB0", VA = "0x182CAA0B0")]
	public static bool MJBJFFOPBBJ<TOk, TErr, UErr, UOk>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TOk LDEKLNNPEJO, out global::DGDFIFNFPJI<UOk, UErr> NHGLMJBPNPN) where TErr : UErr
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9700", Offset = "0x2CA8300", VA = "0x182CA9700")]
	public static bool KAMEMNPHHGD<TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, out TOk LDEKLNNPEJO, out global::DGDFIFNFPJI<CJFIGKJMGNA, TErr> NHGLMJBPNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9320", Offset = "0x2CA7F20", VA = "0x182CA9320")]
	public static global::DGDFIFNFPJI<UOk, UErr> JBDDHNLBGJI<UOk, UErr, TOk, TErr>(this in global::DGDFIFNFPJI<TOk, TErr> JELCPGCJLIH, in global::DGDFIFNFPJI<UOk, UErr> DGKCGFAKKDB) where TOk : UOk where TErr : UErr
	{
		return default(global::DGDFIFNFPJI<UOk, UErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8FF0", Offset = "0x2CA7BF0", VA = "0x182CA8FF0")]
	public static global::DGDFIFNFPJI<TOk[], TErr> HOEDMPNDGOC<TOk, TErr>(this IEnumerable<global::DGDFIFNFPJI<TOk, TErr>> JELCPGCJLIH)
	{
		return default(global::DGDFIFNFPJI<TOk[], TErr>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2965A80", Offset = "0x2964680", VA = "0x182965A80")]
	[IteratorStateMachine(typeof(NNBPIEJDKMM))]
	public static IEnumerable<TOk> OPNNBAEEBHI<TOk, TErr>(this IEnumerable<global::DGDFIFNFPJI<TOk, TErr>> JELCPGCJLIH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MKLLOLKMDAK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A51B40", Offset = "0x2A50740", VA = "0x182A51B40")]
	public static global::DGDFIFNFPJI<TOk, T> HCLIDEODMNH<TOk>(in TOk LDEKLNNPEJO)
	{
		return default(global::DGDFIFNFPJI<TOk, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BF00", Offset = "0x3D9AB00", VA = "0x183D9BF00")]
	public static global::DGDFIFNFPJI<CJFIGKJMGNA, T> HCLIDEODMNH()
	{
		return default(global::DGDFIFNFPJI<CJFIGKJMGNA, T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A51A80", Offset = "0x2A50680", VA = "0x182A51A80")]
	public static global::DGDFIFNFPJI<T, TErr> BCKPFLCBBEL<TErr>(in TErr FLGIAEBOFMA)
	{
		return default(global::DGDFIFNFPJI<T, TErr>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public sealed class LEEJHGKGAJG<T> : IEnumerable<T>, IEnumerable where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private readonly struct DFMBKNHHDKE : IEnumerable<T>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly global::LEEJHGKGAJG<T> DEJOILMADCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int ENDJOCHPFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly bool INPMJMMFLLL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xFEC3B0", Offset = "0xFEAFB0", VA = "0x180FEC3B0")]
		public DFMBKNHHDKE(global::LEEJHGKGAJG<T> ENEHNFBAMKH, int CLONHNJLJCN, bool GLFNOBCDLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D83CB0", Offset = "0x2D828B0", VA = "0x182D83CB0")]
		public global::LEEJHGKGAJG<T>.MNGMMCCGHCO EEAMIAJAFGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D83DA0", Offset = "0x2D829A0", VA = "0x182D83DA0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2D83DA0", Offset = "0x2D829A0", VA = "0x182D83DA0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class MNGMMCCGHCO : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly global::LEEJHGKGAJG<T> DEJOILMADCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly int GLKANHDEOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int JDLGGMPCGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly bool INPMJMMFLLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool DKNFHPPFCMJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public T LEMCHMBGFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4160A10", Offset = "0x415F610", VA = "0x184160A10")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4160BE0", Offset = "0x415F7E0", VA = "0x184160BE0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object? IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x4160C40", Offset = "0x415F840", VA = "0x184160C40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4161200", Offset = "0x415FE00", VA = "0x184161200")]
		public MNGMMCCGHCO(global::LEEJHGKGAJG<T> ENEHNFBAMKH, int CLONHNJLJCN, bool GLFNOBCDLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4160A60", Offset = "0x415F660", VA = "0x184160A60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4160AE0", Offset = "0x415F6E0", VA = "0x184160AE0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class JPEHLGOOOIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x63B510", Offset = "0x63A910")]
		public Func<T> makeDefault;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public JPEHLGOOOIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C52FF0", Offset = "0x3C51BF0", VA = "0x183C52FF0")]
		internal T <.ctor>b__0(int _)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly T[] EBEAOPDAJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private int JDLGGMPCGCK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int DJGDCGPEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2C406F0", Offset = "0x2C3F2F0", VA = "0x182C406F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public T LEMCHMBGFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x2C40730", Offset = "0x2C3F330", VA = "0x182C40730")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public T MKCGMKFKIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x2C405F0", Offset = "0x2C3F1F0", VA = "0x182C405F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public T KKLNJFMENLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x2C40880", Offset = "0x2C3F480", VA = "0x182C40880")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JGBMPNHDFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84B040", Offset = "0x849C40", VA = "0x18084B040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C406D0", Offset = "0x2C3F2D0", VA = "0x182C406D0")]
	private static int EJEHGMHJEFE(int KLEGICPDLIF, int LNLAAEPHJPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2C40990", Offset = "0x2C3F590", VA = "0x182C40990")]
	public LEEJHGKGAJG(int PJGFFECCBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2C40C50", Offset = "0x2C3F850", VA = "0x182C40C50")]
	public LEEJHGKGAJG(int PJGFFECCBBF, Func<T> BMDGNNLLMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2C40A10", Offset = "0x2C3F610", VA = "0x182C40A10")]
	public LEEJHGKGAJG(T[] BPLLJKNAEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2C40620", Offset = "0x2C3F220", VA = "0x182C40620")]
	public void EAHCAAFGKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2C408E0", Offset = "0x2C3F4E0", VA = "0x182C408E0")]
	public IEnumerable<T> OKAMIOLCMEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2C40650", Offset = "0x2C3F250", VA = "0x182C40650")]
	public global::LEEJHGKGAJG<T>.MNGMMCCGHCO EEAMIAJAFGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A365D0", Offset = "0x2A351D0", VA = "0x182A365D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A365D0", Offset = "0x2A351D0", VA = "0x182A365D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class BLIMALKILHN
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2C69EE0", Offset = "0x2C68AE0", VA = "0x182C69EE0")]
	public static global::LEEJHGKGAJG<T> GADFBDMBHED<T>(int PJGFFECCBBF, Func<T> BMDGNNLLMDO) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class DOEDMDCGIBL<TData> : DLGHCKKHLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly string MHNDHCOGBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly TData CDFGGLJDNCL;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "5")]
	public override string NEIJODKECBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2FCE210", Offset = "0x2FCCE10", VA = "0x182FCE210")]
	internal DOEDMDCGIBL(string DPNJMDFICMK, in TData GAGLKGONONJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class PLLGAFMCMJO
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x609DFC0", Offset = "0x609CBC0", VA = "0x18609DFC0")]
	public static global::DOEDMDCGIBL<CJFIGKJMGNA> GADFBDMBHED(string DPNJMDFICMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1E34A90", Offset = "0x1E33690", VA = "0x181E34A90")]
	public static global::DOEDMDCGIBL<TData> GADFBDMBHED<TData>(string DPNJMDFICMK, in TData GAGLKGONONJ)
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
