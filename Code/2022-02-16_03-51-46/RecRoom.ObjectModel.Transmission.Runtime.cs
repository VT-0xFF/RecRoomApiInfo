using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Microsoft.Toolkit.HighPerformance.Buffers;
using Nito.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ENGBDKDGPLG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NECCNONLMJL(int OCICGABDCEM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHCMLDLPANO(int OCICGABDCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BJJPOHGOONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int JEOINKBCAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int IFPLELKELED;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AAKLCPAPNIO : ENGBDKDGPLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private BJJPOHGOONH BGFBEPLKKMD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAB6EA0", Offset = "0xAB56A0", VA = "0x180AB6EA0", Slot = "5")]
	public void DHCMLDLPANO(int OCICGABDCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x495BCE0", Offset = "0x495A4E0", VA = "0x18495BCE0", Slot = "4")]
	public void NECCNONLMJL(int OCICGABDCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x495BCF0", Offset = "0x495A4F0", VA = "0x18495BCF0")]
	public AAKLCPAPNIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NFGPFFAOLMM : KGBBJBIGNDI.NEAKHFIENLA, NACNNELOJCN, DCGJJJCMJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NEOCEHPDGIM KMJFMBGMMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private DEOGJOHIEBG CHGNLCDOJBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x495E320", Offset = "0x495CB20", VA = "0x18495E320", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x495E3A0", Offset = "0x495CBA0", VA = "0x18495E3A0", Slot = "10")]
	public void FLIOOEIFGLA(AEMGILGKGCH DOMICNELCFM, ReadOnlyMemory<byte> KKPFFIGAGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public NFGPFFAOLMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AFNFBBADAKL : KGBBJBIGNDI.NEAKHFIENLA, DCGJJJCMJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GNIICJJHFEI KNDLBNFJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NACNNELOJCN ACBFJHDALMC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x495BD00", Offset = "0x495A500", VA = "0x18495BD00", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x495BD80", Offset = "0x495A580", VA = "0x18495BD80", Slot = "10")]
	public void FLIOOEIFGLA(AEMGILGKGCH DOMICNELCFM, ReadOnlyMemory<byte> KKPFFIGAGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x50AC00", Offset = "0x509400", VA = "0x18050AC00")]
	public AFNFBBADAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NHFBNAPNGEO : KGBBJBIGNDI.NEAKHFIENLA, GNIICJJHFEI, DCGJJJCMJBJ
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct HAPIBBILOOA : IEqualityComparer<HAPIBBILOOA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AEMGILGKGCH DOMICNELCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IMemoryOwner<byte> KKPFFIGAGFM;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2EA8850", Offset = "0x2EA7050", VA = "0x182EA8850")]
		public HAPIBBILOOA(AEMGILGKGCH DOMICNELCFM, IMemoryOwner<byte> KKPFFIGAGFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x495D0E0", Offset = "0x495B8E0", VA = "0x18495D0E0", Slot = "0")]
		public override bool Equals(object JGHAOGLDGDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x495D0B0", Offset = "0x495B8B0", VA = "0x18495D0B0", Slot = "4")]
		public bool Equals(HAPIBBILOOA ODDCIAGBNFM, HAPIBBILOOA AAHOONHJJFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x495D1A0", Offset = "0x495B9A0", VA = "0x18495D1A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x495D1A0", Offset = "0x495B9A0", VA = "0x18495D1A0", Slot = "5")]
		public int GetHashCode(HAPIBBILOOA JGHAOGLDGDA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KKBIOJNDPCO GOGJJDBDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KIEFIDKGADH KOGHKEDCHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly global::OAHHHGHMNCK<Deque<HAPIBBILOOA>> AGLNHLBFFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int LHBKKIEEEOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x495E530", Offset = "0x495CD30", VA = "0x18495E530", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x495E5B0", Offset = "0x495CDB0", VA = "0x18495E5B0", Slot = "11")]
	public void FLIOOEIFGLA(AEMGILGKGCH DOMICNELCFM, ReadOnlyMemory<byte> OKJMAJGLEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x495E6E0", Offset = "0x495CEE0", VA = "0x18495E6E0", Slot = "10")]
	public AEMGILGKGCH JIAFOPPADLD()
	{
		return default(AEMGILGKGCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x495E750", Offset = "0x495CF50", VA = "0x18495E750")]
	public NHFBNAPNGEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BFKMELMNMAL : EJDGLJJGFEM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LJODAKGEJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69E820", Offset = "0x69D020", VA = "0x18069E820", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	[Preserve]
	public BFKMELMNMAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x495BEF0", Offset = "0x495A6F0", VA = "0x18495BEF0", Slot = "5")]
	public void JGOKPIEGJOM(PNDEHDGDOBH EKBADBPPBLL, KIEFIDKGADH KOGHKEDCHDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NJBFOBBKAGC : KGBBJBIGNDI.NEAKHFIENLA, AFCILMMABCK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KIEFIDKGADH KOGHKEDCHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private NEOCEHPDGIM KMJFMBGMMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private GNIICJJHFEI KNDLBNFJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private EJDGLJJGFEM NLICAHIFFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private int KGFBKBMEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private byte[] KIJIMACKNGN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PNDEHDGDOBH APOACICKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x50A7D0", Offset = "0x508FD0", VA = "0x18050A7D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ED2D0", Offset = "0x7EBAD0", VA = "0x1807ED2D0", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x495EFA0", Offset = "0x495D7A0", VA = "0x18495EFA0")]
	public NJBFOBBKAGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x495F020", Offset = "0x495D820", VA = "0x18495F020")]
	public NJBFOBBKAGC(int KGFBKBMEJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x495E7E0", Offset = "0x495CFE0", VA = "0x18495E7E0", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x495E920", Offset = "0x495D120", VA = "0x18495E920", Slot = "7")]
	public sealed override void BHKOMAJNLIG(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x495EB00", Offset = "0x495D300", VA = "0x18495EB00", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x495EEF0", Offset = "0x495D6F0", VA = "0x18495EEF0", Slot = "11")]
	public void JBMPIMPHHPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x495EF50", Offset = "0x495D750", VA = "0x18495EF50", Slot = "12")]
	public void PJENJMCKFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x495EB90", Offset = "0x495D390", VA = "0x18495EB90")]
	private void FMKHFOMHKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x495EAD0", Offset = "0x495D2D0", VA = "0x18495EAD0")]
	private void DOMHLGLAIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LCFLBCCCIGO : NEOCEHPDGIM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly bool DCJFPNIIMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private byte[] OEJHJGKKKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private byte[] GBGPCMOBNKK;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xB8D870", Offset = "0xB8C070", VA = "0x180B8D870")]
	public LCFLBCCCIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x645420", Offset = "0x643C20", VA = "0x180645420")]
	public LCFLBCCCIGO(bool DCJFPNIIMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x495DE90", Offset = "0x495C690", VA = "0x18495DE90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x495DD50", Offset = "0x495C550", VA = "0x18495DD50", Slot = "4")]
	public void CFBGFFOINCO(int GDBDJPILDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x495DF50", Offset = "0x495C750", VA = "0x18495DF50")]
	public void KLODNPEFEIH(in ReadOnlyMemory<byte> ABHCPJJMKJD, out ReadOnlyMemory<byte> NIBFHOHDCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x495D980", Offset = "0x495C180", VA = "0x18495D980")]
	public void BJNKEOBFOJC(in ReadOnlyMemory<byte> ABHCPJJMKJD, out ReadOnlyMemory<byte> NIBFHOHDCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x495DF30", Offset = "0x495C730", VA = "0x18495DF30", Slot = "5")]
	private void FKGPPIJGHHD(in ReadOnlyMemory<byte> ABHCPJJMKJD, out ReadOnlyMemory<byte> NIBFHOHDCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x495DF40", Offset = "0x495C740", VA = "0x18495DF40", Slot = "6")]
	private void GAIFPLLAOGJ(in ReadOnlyMemory<byte> ABHCPJJMKJD, out ReadOnlyMemory<byte> NIBFHOHDCPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CHDBKDPAFBC : KKBIOJNDPCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private uint GOGJJDBDAHJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private uint HDECBHIJEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x507010", Offset = "0x505810", VA = "0x180507010", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
	public CHDBKDPAFBC(uint GOGJJDBDAHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GPLEEBAIJKI : KGBBJBIGNDI.NEAKHFIENLA, DEOGJOHIEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private global::JFCONEEKBFE<JNJCHABBGGJ> PDOAPEBGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private global::JFCONEEKBFE<MOGNIHBNMND> BLFGFCHPHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KKBIOJNDPCO GOGJJDBDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly PNDEHDGDOBH APKEPEIJPBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x495D040", Offset = "0x495B840", VA = "0x18495D040")]
	[Preserve]
	public GPLEEBAIJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x495CD70", Offset = "0x495B570", VA = "0x18495CD70", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x495CE10", Offset = "0x495B610", VA = "0x18495CE10", Slot = "10")]
	public void OJGEFMOALKD(AEMGILGKGCH DOMICNELCFM, ReadOnlyMemory<byte> OKJMAJGLEPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GMPLHPHBLBG<ObjectId> : KGBBJBIGNDI.NEAKHFIENLA, global::JFCONEEKBFE<ObjectId> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private global::PIPDAMBDOBA<ObjectId> IJEJGOMPLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private global::PBAHNDJBFJK<ObjectId> PJPOJJNLDJK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6F80", Offset = "0x2AC5780", VA = "0x182AC6F80")]
	[Preserve]
	public GMPLHPHBLBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD630", Offset = "0x2BDBE30", VA = "0x182BDD630", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BDE8B0", Offset = "0x2BDD0B0", VA = "0x182BDE8B0", Slot = "10")]
	public void OJGEFMOALKD(PNDEHDGDOBH APKEPEIJPBH, OKAKAADJMMJ NKPLONGOGNO, bool MHBJIKDICNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD6B0", Offset = "0x2BDBEB0", VA = "0x182BDD6B0")]
	public void BBLGPGIDECK(ObjectId BDCCAPDCEBB, bool MHBJIKDICNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD6B0", Offset = "0x2BDBEB0", VA = "0x182BDD6B0")]
	public void ENKEKNLNNDK(ObjectId BDCCAPDCEBB, bool MHBJIKDICNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD950", Offset = "0x2BDC150", VA = "0x182BDD950")]
	public void EIAAABJJBDL(ObjectId BDCCAPDCEBB, bool MHBJIKDICNB, PNDEHDGDOBH APKEPEIJPBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DDJMDEFOJJC<ObjectId> : KGBBJBIGNDI.NEAKHFIENLA, global::NIJLAADCOHB<ObjectId> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private global::PIPDAMBDOBA<ObjectId> AKPJLEFOMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private AFCILMMABCK MEPFNOBDHGM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private PNDEHDGDOBH PMAIAIDMOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2BED410", Offset = "0x2BEBC10", VA = "0x182BED410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC5B0", Offset = "0x2BEADB0", VA = "0x182BEC5B0", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC910", Offset = "0x2BEB110", VA = "0x182BEC910", Slot = "10")]
	public void CDFPAMOFPKC(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC940", Offset = "0x2BEB140", VA = "0x182BEC940", Slot = "11")]
	public void MDHJBGMNLBP(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2BECFB0", Offset = "0x2BEB7B0", VA = "0x182BECFB0")]
	private void MIPNPDFGNIA(OKAKAADJMMJ MOGKBDHNMLA, ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E5E0", Offset = "0x2D4CDE0", VA = "0x182D4E5E0")]
	public void AAANEKFLDGL<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T HNCFAALBJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6F80", Offset = "0x2AC5780", VA = "0x182AC6F80")]
	public DDJMDEFOJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA450", Offset = "0x2BB8C50", VA = "0x182BBA450", Slot = "12")]
	private void EBFMBAJFAKG<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T HNCFAALBJCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CILCJJHCOME
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public sealed class OMFAOEDACGM : global::KBNKIKMDLFO<OMFAOEDACGM, JNJCHABBGGJ, GPOPJFOCHAM, OAKBFNJLFCB, JBCMDLEJLLO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x495F1D0", Offset = "0x495D9D0", VA = "0x18495F1D0", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x495F3F0", Offset = "0x495DBF0", VA = "0x18495F3F0")]
		public OMFAOEDACGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class DKIDFMHMIIB : global::KBNKIKMDLFO<DKIDFMHMIIB, MOGNIHBNMND, DGCCPGOCGOH, FAMNNDFAADK, CJNIMKFHAII>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x495C360", Offset = "0x495AB60", VA = "0x18495C360", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x495C580", Offset = "0x495AD80", VA = "0x18495C580")]
		public DKIDFMHMIIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class LALIHMMKCCE : global::KBNKIKMDLFO<LALIHMMKCCE, JJIIMHLKKNO, KOPNBPMBGJD, LCGJAOHLKGG, GBEFNGPJPFB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x495D720", Offset = "0x495BF20", VA = "0x18495D720", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x495D940", Offset = "0x495C140", VA = "0x18495D940")]
		public LALIHMMKCCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class HFONMKKCBLB : global::KBNKIKMDLFO<HFONMKKCBLB, BECOBNJDPAO, HIMDCNANFCE, EAOAOFPFCKO, DMOEDOPGCIE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x495D200", Offset = "0x495BA00", VA = "0x18495D200", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x495D420", Offset = "0x495BC20", VA = "0x18495D420")]
		public HFONMKKCBLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class GDNCDKANODG : global::KBNKIKMDLFO<GDNCDKANODG, OGLKGJDJCEK, BICOONBOILH, HHBHIMOHMHP, ILIPFIHLCMG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x495C5C0", Offset = "0x495ADC0", VA = "0x18495C5C0", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x495C7E0", Offset = "0x495AFE0", VA = "0x18495C7E0")]
		public GDNCDKANODG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class KAIMMFHKAFI : global::KBNKIKMDLFO<KAIMMFHKAFI, ENGIPCOPMJM, FNPFHPIAOKE, PMMNACFPAKB, HAOLHDPGBFI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override HHOHHAHOHDA JMKMJEPMFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x495D460", Offset = "0x495BC60", VA = "0x18495D460", Slot = "19")]
			get
			{
				return default(HHOHHAHOHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x495D680", Offset = "0x495BE80", VA = "0x18495D680")]
		public KAIMMFHKAFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x495BF30", Offset = "0x495A730", VA = "0x18495BF30")]
	public static void IOPLHEAILCG(FPFKNDBFEBA JBCKDMDLCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x495C2D0", Offset = "0x495AAD0", VA = "0x18495C2D0")]
	public static void MBIMOJNHFGH(KGBBJBIGNDI POAOKGHJJDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class LMJFAAPNCBO<ObjectId> : IDisposable where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool GDMDAIEPCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ObjectId BDCCAPDCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private DODAPBIEPCA JIFHELOEDHG;

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3526B10", Offset = "0x3525310", VA = "0x183526B10")]
	public IDisposable OALNFBLCHMK(in ObjectId BDCCAPDCEBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3526AA0", Offset = "0x35252A0", VA = "0x183526AA0")]
	public IDisposable DJEBCIDECLB(in ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3526A70", Offset = "0x3525270", VA = "0x183526A70")]
	public bool DGMIDOBLLNG(in ObjectId OLJALKGAFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3526AC0", Offset = "0x35252C0", VA = "0x183526AC0")]
	public bool MMANNALCGOB(in ObjectId OLJALKGAFMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x3526AF0", Offset = "0x35252F0", VA = "0x183526AF0")]
	public bool NKIEGOJGGAC(in ObjectId OLJALKGAFMH, DODAPBIEPCA PLEKLENOMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xD03D90", Offset = "0xD02590", VA = "0x180D03D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
	public LMJFAAPNCBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FENHPPDDIBN<ObjectId, ObjectIdx> : KGBBJBIGNDI.NEAKHFIENLA, global::EELEHNJLJKC<ObjectId, ObjectIdx>, global::PBAHNDJBFJK<ObjectId>, global::LEMJJPMBAJO<ObjectId> where ObjectId : struct, BBHDKPAHPDH where ObjectIdx : struct, BFCPFBCCIKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private global::HMMLHHDKDBD<ObjectId, ObjectIdx> OEEGKOJDAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly global::JIEIAFEIJHA<ObjectId> JMIAPBEAADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly global::LDOECEJPBIM<ObjectId> JDMPLIKLCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly global::LDOECEJPBIM<ObjectId> EMGPFLPPACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private global::NIJLAADCOHB<ObjectId> LMOEIMPHKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private global::LMJFAAPNCBO<ObjectId> GACJMDKFMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[CompilerGenerated]
	private Action<ObjectId, DODAPBIEPCA, object> DGEBMNLBNEH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public global::HMMLHHDKDBD<ObjectId, ObjectIdx> GOPOOIFEKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KNGFIICMJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x50DF70", Offset = "0x50C770", VA = "0x18050DF70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3709A70", Offset = "0x3708270", VA = "0x183709A70")]
	public FENHPPDDIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3707020", Offset = "0x3705820", VA = "0x183707020", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x37070B0", Offset = "0x37058B0", VA = "0x1837070B0", Slot = "13")]
	public void EKACBINBAAO(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x3708CA0", Offset = "0x37074A0", VA = "0x183708CA0", Slot = "14")]
	public void IMLHNNJAGCD(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x368A810", Offset = "0x3689010", VA = "0x18368A810")]
	public void OIOOOMLOJOC<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T DOIIECBDBFB, in T EACOKIMHCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3709460", Offset = "0x3707C60", VA = "0x183709460", Slot = "11")]
	public void JGEAHDMNOIJ(ObjectId BDCCAPDCEBB, bool DAPFKCHACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x368E160", Offset = "0x368C960", VA = "0x18368E160")]
	public void OLNPCCKHJMN<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3709A00", Offset = "0x3708200", VA = "0x183709A00")]
	private void NDONGAHPHNL(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3707150", Offset = "0x3705950", VA = "0x183707150")]
	private void GJBKNPLMEOE(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x2D47BE0", Offset = "0x2D463E0", VA = "0x182D47BE0", Slot = "12")]
	private void GCLOCHBFLGO<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x368A4F0", Offset = "0x3688CF0", VA = "0x18368A4F0", Slot = "15")]
	private void BCFNGCJGCPP<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T DOIIECBDBFB, in T EACOKIMHCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3709920", Offset = "0x3708120", VA = "0x183709920")]
	[CompilerGenerated]
	private object MNOONOLMLGJ(ObjectId BDCCAPDCEBB, DODAPBIEPCA AKFOGOAFJPM, object OOGAPICNMPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JIEIAFEIJHA<ObjectId> : global::ACOFDLEEABO<ObjectId>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Dictionary<DODAPBIEPCA, object> ONOBCIEBNMK;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x36985D0", Offset = "0x3696DD0", VA = "0x1836985D0")]
	public void INBEPNKKEGJ<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T DOIIECBDBFB, in T KOBJIEJCHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9BC0", Offset = "0x2CA83C0", VA = "0x182CA9BC0", Slot = "4")]
	public bool CBJIDFLHCOO<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, out T DOIIECBDBFB, out T KOBJIEJCHGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA810", Offset = "0x2CA9010", VA = "0x182CAA810", Slot = "6")]
	public bool EJDEKLMKEPG<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x2CABFE0", Offset = "0x2CAA7E0", VA = "0x182CABFE0")]
	public bool NCOGJNNENFB<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T OIPDCOINLBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B55E80", Offset = "0x3B54680", VA = "0x183B55E80")]
	public JIEIAFEIJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x2BBA450", Offset = "0x2BB8C50", VA = "0x182BBA450", Slot = "5")]
	private bool AKDNELODNKI<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T OIPDCOINLBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct MDJKIEHGAPK<T> : IEquatable<global::MDJKIEHGAPK<T>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public T OIPDCOINLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public T AAFKMEHEENC;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x19A4B50", Offset = "0x19A3350", VA = "0x1819A4B50")]
	public MDJKIEHGAPK(T OIPDCOINLBO, T AAFKMEHEENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x366A890", Offset = "0x3669090", VA = "0x18366A890", Slot = "4")]
	public bool Equals(global::MDJKIEHGAPK<T> AJEOGBNDGHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct ABIGCNBFDLO<ObjectId, ObjectIdx> where ObjectId : struct, BBHDKPAHPDH where ObjectIdx : struct, BFCPFBCCIKF
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HLNJIIKAJFM<TCallback> where TCallback : Delegate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Action<TCallback> remover;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public TCallback callback;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public HLNJIIKAJFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2726EB0", Offset = "0x27256B0", VA = "0x182726EB0")]
		internal void <Create>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private Action<ObjectId> MPAOHAFOLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private Action NKOPBNKGOJF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool IGNOPHGBLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x620410", Offset = "0x61EC10", VA = "0x180620410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F33B40", Offset = "0x3F32340", VA = "0x183F33B40")]
	public void HBLBNLLMEPO(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F33BD0", Offset = "0x3F323D0", VA = "0x183F33BD0")]
	public void MIJAAKNMDAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3132020", Offset = "0x3130820", VA = "0x183132020")]
	public static global::ABIGCNBFDLO<ObjectId, ObjectIdx> OALNFBLCHMK<TCallback>(global::LEMJJPMBAJO<ObjectId> DIEFFDBNPMB, Action<ObjectId> MPAOHAFOLIO, TCallback HIHNOBNGGBK, Action<TCallback> GPCEPKCHEHB, Action<TCallback> CMLJAGJHFLE, bool OOOJMIAHJHN) where TCallback : Delegate
	{
		return default(global::ABIGCNBFDLO<ObjectId, ObjectIdx>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public abstract class KBNKIKMDLFO<Self, ObjectId, ObjectIdx, TObjectSystem, TIObjectSystem> : KGBBJBIGNDI.NEAKHFIENLA, global::HMMLHHDKDBD<ObjectId, ObjectIdx>, IDisposable where Self : global::KBNKIKMDLFO<Self, ObjectId, ObjectIdx, TObjectSystem, TIObjectSystem>, new() where ObjectId : struct, BBHDKPAHPDH where ObjectIdx : struct, BFCPFBCCIKF where TObjectSystem : global::HAPDPIFALHK<ObjectId, ObjectIdx>, TIObjectSystem, new() where TIObjectSystem : class
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HHOHHAHOHDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KHPEONHGFHL IFLENLCLALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public DODAPBIEPCA HOJGHCPHAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public DODAPBIEPCA POOENGJGCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public global::KGPEIGCMEMC<ObjectId> HFMDEOLHBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public global::FOGCAPGMHPF<ObjectIdx> OACNDELEPNK;

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x36765F0", Offset = "0x3674DF0", VA = "0x1836765F0")]
		public static HHOHHAHOHDA MHMBBDCGHFI((KHPEONHGFHL objectType, DODAPBIEPCA propertyStart, DODAPBIEPCA propertyEnd, global::KGPEIGCMEMC<ObjectId> createId, global::FOGCAPGMHPF<ObjectIdx> createIdx) MNDCOADKALO)
		{
			return default(HHOHHAHOHDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MKPIIBCGLJN : IEnumerable<(DODAPBIEPCA, object)>, IEnumerable, IEnumerator<(DODAPBIEPCA, object)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private (DODAPBIEPCA, object) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public global::KBNKIKMDLFO<Self, ObjectId, ObjectIdx, TObjectSystem, TIObjectSystem> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ObjectId objectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public ObjectId <>3__objectId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private Dictionary<DODAPBIEPCA, global::OLPNBBDEIPH<ObjectId, ObjectIdx>>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private (DODAPBIEPCA, object) System.Collections.Generic.IEnumerator<(RecRoom.ObjectModel.PropertyId,System.Object)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x52F9D0", Offset = "0x52E1D0", VA = "0x18052F9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DODAPBIEPCA, object));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3686EB0", Offset = "0x36856B0", VA = "0x183686EB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x2BEBE60", Offset = "0x2BEA660", VA = "0x182BEBE60")]
		[DebuggerHidden]
		public MKPIIBCGLJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3687100", Offset = "0x3685900", VA = "0x183687100", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3686080", Offset = "0x3684880", VA = "0x183686080", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3687200", Offset = "0x3685A00", VA = "0x183687200")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3686B40", Offset = "0x3685340", VA = "0x183686B40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3686A80", Offset = "0x3685280", VA = "0x183686A80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DODAPBIEPCA, object)> System.Collections.Generic.IEnumerable<(RecRoom.ObjectModel.PropertyId,System.Object)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x2C034B0", Offset = "0x2C01CB0", VA = "0x182C034B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<DODAPBIEPCA, global::OLPNBBDEIPH<ObjectId, ObjectIdx>> IJEJGOMPLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private global::HAPDPIFALHK<ObjectId, ObjectIdx> IGNCNPNNLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private global::ABIGCNBFDLO<ObjectId, ObjectIdx> GEGMFCCNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private global::ABIGCNBFDLO<ObjectId, ObjectIdx> BECFACGNOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private global::LEMJJPMBAJO<ObjectId> PJGAPEMPOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private global::PIPDAMBDOBA<ObjectId> ABFEAMIEDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private FPFKNDBFEBA FEJKEPCCEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private global::KNOBBAGBACP<ObjectId, ObjectIdx> ODIGKOILJLH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public abstract HHOHHAHOHDA JMKMJEPMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x367E350", Offset = "0x367CB50", VA = "0x18367E350", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3679B90", Offset = "0x3678390", VA = "0x183679B90", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x367B570", Offset = "0x3679D70", VA = "0x18367B570", Slot = "7")]
	public sealed override void BHKOMAJNLIG(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x367EE00", Offset = "0x367D600", VA = "0x18367EE00")]
	private void MFDJFDLHFHG(global::OLPNBBDEIPH<ObjectId, ObjectIdx> OEEGKOJDAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x367EF10", Offset = "0x367D710", VA = "0x18367EF10", Slot = "12")]
	public bool PHFODMAEJHF(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x367EBF0", Offset = "0x367D3F0", VA = "0x18367EBF0", Slot = "13")]
	public void HJNLJHKAMIA(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, bool AKDDEFCGJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x367C630", Offset = "0x367AE30", VA = "0x18367C630")]
	public static void DKALKLLGGCK(KGBBJBIGNDI POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x367EE80", Offset = "0x367D680", VA = "0x18367EE80", Slot = "14")]
	public void NDONGAHPHNL(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x367EAC0", Offset = "0x367D2C0", VA = "0x18367EAC0", Slot = "15")]
	public void GJBKNPLMEOE(ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	public bool DJEBCIDECLB<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG, in T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	public bool KHKDDCIJOFM<T>(global::ACOFDLEEABO<ObjectId> MNGGILDCDGE, DODAPBIEPCA JIFHELOEDHG, in T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x367EAE0", Offset = "0x367D2E0", VA = "0x18367EAE0", Slot = "11")]
	[IteratorStateMachine(typeof(global::KBNKIKMDLFO<, , , , >.MKPIIBCGLJN))]
	public IEnumerable<(DODAPBIEPCA, object)> GJJCNFBCEGM(ObjectId BDCCAPDCEBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x367A3C0", Offset = "0x3678BC0", VA = "0x18367A3C0", Slot = "10")]
	public object AFJLEEHMHNF(ObjectId BDCCAPDCEBB, DODAPBIEPCA JIFHELOEDHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x367F080", Offset = "0x367D880", VA = "0x18367F080")]
	protected KBNKIKMDLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	private bool AMIOLGMHKFI<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	private bool OMDHJMAELFC<T>(global::ACOFDLEEABO<ObjectId> MNGGILDCDGE, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x367EEA0", Offset = "0x367D6A0", VA = "0x18367EEA0")]
	[CompilerGenerated]
	private void PCPBCEBNBCC(ObjectId KCKIAGIOHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x367ECD0", Offset = "0x367D4D0", VA = "0x18367ECD0")]
	[CompilerGenerated]
	private void IOMPOOAFGDO(ObjectIdx NLAANMDHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x367A4C0", Offset = "0x3678CC0", VA = "0x18367A4C0")]
	[CompilerGenerated]
	private void AHKHDHCCGOH(global::CANJEEKGECB<ObjectIdx> DGNGOIEGJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x367ED90", Offset = "0x367D590", VA = "0x18367ED90")]
	[CompilerGenerated]
	private void MDDIDOAGIAB(global::CANJEEKGECB<ObjectIdx> DGNGOIEGJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x367E9B0", Offset = "0x367D1B0", VA = "0x18367E9B0")]
	[CompilerGenerated]
	private void EDGGNINECOP(ObjectId KCKIAGIOHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x367EFC0", Offset = "0x367D7C0", VA = "0x18367EFC0")]
	[CompilerGenerated]
	private void PPKDLLPKLFO(ObjectIdx NLAANMDHJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x367C5C0", Offset = "0x367ADC0", VA = "0x18367C5C0")]
	[CompilerGenerated]
	private void CCFGMCMLPNJ(global::EPKPFOOFBDC<ObjectIdx> DGNGOIEGJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x367EB80", Offset = "0x367D380", VA = "0x18367EB80")]
	[CompilerGenerated]
	private void HHEJAKNHFCB(global::EPKPFOOFBDC<ObjectIdx> DGNGOIEGJNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MBOIMLBJNBM<ObjectId, ObjectIdx> : global::MKHPAAMJEAB<ObjectId> where ObjectId : struct, BBHDKPAHPDH where ObjectIdx : struct, BFCPFBCCIKF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class ECKJMPGAIAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public global::FJEBIBGGLGK<ObjectIdx> propOwner;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public ECKJMPGAIAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3661090", Offset = "0x365F890", VA = "0x183661090")]
		internal CCLFPOFDAAO <GetProperties>b__1(PropertyInfo p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly Dictionary<Type, KCNDCDICKKE> DGAPOAEFKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly global::LEMJJPMBAJO<ObjectId> DIEFFDBNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Action<global::OLPNBBDEIPH<ObjectId, ObjectIdx>> MDOAPMGHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly global::PIPDAMBDOBA<ObjectId> ABFEAMIEDBD;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public global::LEMJJPMBAJO<ObjectId> KPHPENIMFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3662E10", Offset = "0x3661610", VA = "0x183662E10")]
	public static void DLGKIGDNFDJ(FBFPMBJINOF LCIKPJLCODN, global::LEMJJPMBAJO<ObjectId> DIEFFDBNPMB, Action<global::OLPNBBDEIPH<ObjectId, ObjectIdx>> MDOAPMGHJDF, global::PIPDAMBDOBA<ObjectId> ABFEAMIEDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEE20", Offset = "0x2AED620", VA = "0x182AEEE20", Slot = "4")]
	public global::HAPDPIFALHK<TId, TIdx> NJKMLHKCKDE<TId, TIdx>() where TId : struct, BBHDKPAHPDH where TIdx : struct, BFCPFBCCIKF
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3668270", Offset = "0x3666A70", VA = "0x183668270")]
	private MBOIMLBJNBM(Dictionary<Type, KCNDCDICKKE> DGAPOAEFKOL, global::LEMJJPMBAJO<ObjectId> DIEFFDBNPMB, Action<global::OLPNBBDEIPH<ObjectId, ObjectIdx>> MDOAPMGHJDF, global::PIPDAMBDOBA<ObjectId> ABFEAMIEDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x36678C0", Offset = "0x36660C0", VA = "0x1836678C0")]
	private static void OEIFEJDMDJA(FBFPMBJINOF LCIKPJLCODN, out Dictionary<Type, KCNDCDICKKE> FGJBHLMGBJM, out List<global::FJEBIBGGLGK<ObjectIdx>> AKHELAIEJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3665BA0", Offset = "0x36643A0", VA = "0x183665BA0")]
	private static void NOCCIGHEHHG(object BALECEBKGJK, Dictionary<Type, KCNDCDICKKE> FGJBHLMGBJM, List<global::FJEBIBGGLGK<ObjectIdx>> AKHELAIEJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3662790", Offset = "0x3660F90", VA = "0x183662790")]
	private void BGEHJFHDONH(global::FJEBIBGGLGK<ObjectIdx> LFHNFHKPFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3664D30", Offset = "0x3663530", VA = "0x183664D30")]
	private IEnumerable<CCLFPOFDAAO> GJJCNFBCEGM(global::FJEBIBGGLGK<ObjectIdx> LFHNFHKPFJC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct KCNDCDICKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public readonly Type BDCCAPDCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public readonly Type DPBDIHIIFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public readonly object IGNCNPNNLKK;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x495D6C0", Offset = "0x495BEC0", VA = "0x18495D6C0")]
	public KCNDCDICKKE(object IGNCNPNNLKK, Type BDCCAPDCEBB, Type DPBDIHIIFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface FPFKNDBFEBA : global::ALPODKOLBII<FPFKNDBFEBA>
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKALKLLGGCK<T>(global::MLMFHPDLJLE<T> ELLILLBFBNO, global::IKKEHKDEAME<T> CLIOMFFMPFN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIAGFGIAAPA(Type BJNLFFPNEBC, out Delegate AKPJLEFOMKG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CHNENFNJGDM(Type BJNLFFPNEBC, out Delegate AKPJLEFOMKG);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class NIKAHOGDCKK<ObjectId> : KGBBJBIGNDI.NEAKHFIENLA, global::PIPDAMBDOBA<ObjectId>, global::ALPODKOLBII<global::PIPDAMBDOBA<ObjectId>> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FGIJCPIHAOD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public global::IKKEHKDEAME<T> deserializerValue;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public FGIJCPIHAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x360B700", Offset = "0x3609F00", VA = "0x18360B700")]
		internal void <ConstructTypedDeserializeCallback>b__0(global::PBAHNDJBFJK<ObjectId> view, PNDEHDGDOBH packer, ObjectId objectId, DODAPBIEPCA propertyId, bool isAck)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Dictionary<DODAPBIEPCA, Delegate> JBCKDMDLCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<DODAPBIEPCA, Delegate> KNKPGPJPOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private FPFKNDBFEBA FEJKEPCCEDL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool HHFAPIHBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E3200", Offset = "0x5E1A00", VA = "0x1805E3200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E3250", Offset = "0x5E1A50", VA = "0x1805E3250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x361B330", Offset = "0x3619B30", VA = "0x18361B330")]
	public NIKAHOGDCKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x361ABD0", Offset = "0x36193D0", VA = "0x18361ABD0")]
	public NIKAHOGDCKK(Dictionary<DODAPBIEPCA, Delegate> JBCKDMDLCLD, Dictionary<DODAPBIEPCA, Delegate> KNKPGPJPOPD, bool IFKPGFIPFKD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3617EF0", Offset = "0x36166F0", VA = "0x183617EF0", Slot = "6")]
	public override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3618220", Offset = "0x3616A20", VA = "0x183618220", Slot = "7")]
	public override void BHKOMAJNLIG(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x38368F0", Offset = "0x38350F0", VA = "0x1838368F0", Slot = "10")]
	public void DKALKLLGGCK<T>(DODAPBIEPCA KCKIAGIOHJN, global::MLMFHPDLJLE<T> ELLILLBFBNO, global::IKKEHKDEAME<T> CLIOMFFMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x361A620", Offset = "0x3618E20", VA = "0x18361A620", Slot = "14")]
	public bool FIAGFGIAAPA(DODAPBIEPCA KCKIAGIOHJN, out Delegate HIHNOBNGGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public bool FIAGFGIAAPA<T>(DODAPBIEPCA KCKIAGIOHJN, out global::MLMFHPDLJLE<T> HIHNOBNGGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3619170", Offset = "0x3617970", VA = "0x183619170", Slot = "11")]
	public bool CHNENFNJGDM(DODAPBIEPCA KCKIAGIOHJN, out global::GJNDAEFJKBB<ObjectId> HIHNOBNGGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3619420", Offset = "0x3617C20", VA = "0x183619420")]
	private global::GJNDAEFJKBB<ObjectId> EHFECCEINNP(Type BJNLFFPNEBC, Delegate NOCGGMBMBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2AF21C0", Offset = "0x2AF09C0", VA = "0x182AF21C0")]
	[Preserve]
	private static global::GJNDAEFJKBB<ObjectId> AFIHLCDJOKH<T>(Delegate NOCGGMBMBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x361A920", Offset = "0x3619120", VA = "0x18361A920", Slot = "13")]
	public global::PIPDAMBDOBA<ObjectId> GOLMLPBBLFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PLCIJKIAKKK : KGBBJBIGNDI.NEAKHFIENLA, FPFKNDBFEBA, global::ALPODKOLBII<FPFKNDBFEBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly Dictionary<Type, Delegate> JBCKDMDLCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly Dictionary<Type, Delegate> KNKPGPJPOPD;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool HHFAPIHBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC0", Offset = "0x52D3C0", VA = "0x18052EBC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C90", Offset = "0x5CF490", VA = "0x1805D0C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x495F690", Offset = "0x495DE90", VA = "0x18495F690")]
	public PLCIJKIAKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x495F730", Offset = "0x495DF30", VA = "0x18495F730")]
	public PLCIJKIAKKK(Dictionary<Type, Delegate> JBCKDMDLCLD, Dictionary<Type, Delegate> KNKPGPJPOPD, bool IFKPGFIPFKD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x495F430", Offset = "0x495DC30", VA = "0x18495F430", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3838DA0", Offset = "0x38375A0", VA = "0x183838DA0", Slot = "10")]
	public void DKALKLLGGCK<T>(global::MLMFHPDLJLE<T> ELLILLBFBNO, global::IKKEHKDEAME<T> CLIOMFFMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x495F510", Offset = "0x495DD10", VA = "0x18495F510", Slot = "11")]
	public bool FIAGFGIAAPA(Type BJNLFFPNEBC, out Delegate AKPJLEFOMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x495F4A0", Offset = "0x495DCA0", VA = "0x18495F4A0", Slot = "12")]
	public bool CHNENFNJGDM(Type BJNLFFPNEBC, out Delegate AKPJLEFOMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x495F580", Offset = "0x495DD80", VA = "0x18495F580", Slot = "13")]
	public FPFKNDBFEBA GOLMLPBBLFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GLLOPEFGMAH : KGBBJBIGNDI.NEAKHFIENLA, EDBKJCPEKAL
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LLNMLBFGHCP<ObjectId> : DCMDMBKJJDL, global::PBAHNDJBFJK<ObjectId> where ObjectId : struct, BBHDKPAHPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::PBAHNDJBFJK<ObjectId> PJGAPEMPOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly global::PBAHNDJBFJK<ObjectId> PJPOJJNLDJK;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool AKBLJDLJMEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x52EBC0", Offset = "0x52D3C0", VA = "0x18052EBC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private global::PBAHNDJBFJK<ObjectId> KPHPENIMFBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2BE29C0", Offset = "0x2BE11C0", VA = "0x182BE29C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public KGCEJBNEOAN DOGMKDAFGIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7ED2D0", Offset = "0x7EBAD0", VA = "0x1807ED2D0", Slot = "4")]
			get
			{
				return default(KGCEJBNEOAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6F50", Offset = "0x2AD5750", VA = "0x182AD6F50")]
		public LLNMLBFGHCP(global::PBAHNDJBFJK<ObjectId> AFLMNKHODOH, global::PBAHNDJBFJK<ObjectId> BLONOGHKCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2930", Offset = "0x2BE1130", VA = "0x182BE2930", Slot = "6")]
		public void JGEAHDMNOIJ(ObjectId BDCCAPDCEBB, bool DAPFKCHACNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x3699E10", Offset = "0x3698610", VA = "0x183699E10")]
		public void OLNPCCKHJMN<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2BE2850", Offset = "0x2BE1050", VA = "0x182BE2850", Slot = "5")]
		public void CEDBFBPEFFC(POBOFAIGPBJ POAOKGHJJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2D47BE0", Offset = "0x2D463E0", VA = "0x182D47BE0", Slot = "7")]
		private void GCLOCHBFLGO<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private KGBBJBIGNDI POAOKGHJJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private POBOFAIGPBJ ACLDALHDBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private DEOGJOHIEBG CHGNLCDOJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private GNIICJJHFEI KNDLBNFJJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NEOCEHPDGIM KMJFMBGMMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private KIFIABMFLOJ ODMPJPBHDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private global::AHCEDHJCFKP<JNJCHABBGGJ> PJBAPEKPCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private global::AHCEDHJCFKP<MOGNIHBNMND> JIBLJHEOBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private PNDEHDGDOBH PMAIAIDMOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private LLNMLBFGHCP<JNJCHABBGGJ> ENDIPGAGHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private LLNMLBFGHCP<MOGNIHBNMND> PECBEMAKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly global::OAHHHGHMNCK<JDNNFLGDBLE> LEMNJNEGPFK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x762360", Offset = "0x760B60", VA = "0x180762360", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x495C820", Offset = "0x495B020", VA = "0x18495C820", Slot = "8")]
	public sealed override void AAJFCBMGPMG(POBOFAIGPBJ NLEHIBGBOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x495CB70", Offset = "0x495B370", VA = "0x18495CB70")]
	public GLLOPEFGMAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class AHCEDHJCFKP<ObjectId> : KGBBJBIGNDI.NEAKHFIENLA, global::PBAHNDJBFJK<ObjectId>, IDisposable where ObjectId : struct, BBHDKPAHPDH, IEquatable<ObjectId>, IComparable<ObjectId>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct IKCIBAKICFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int BIJBEGOMFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public int MGNDGEJKDHG;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6EB420", Offset = "0x6E9C20", VA = "0x1806EB420")]
		public IKCIBAKICFC(int BIJBEGOMFPC, int MGNDGEJKDHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly SortedDictionary<ObjectId, SortedDictionary<DODAPBIEPCA, IKCIBAKICFC>> PCGOLBCDHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private global::PIPDAMBDOBA<ObjectId> AKPJLEFOMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private global::PBAHNDJBFJK<ObjectId> DIEFFDBNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly PNDEHDGDOBH NHIIMMHOFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private ArrayPoolBufferWriter<byte> CBILNDCBDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Stream ANJINIIPBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private uint OHFEHAIHNHL;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B20030", Offset = "0x2B1E830", VA = "0x182B20030")]
	private void DKJALJKKAKM(in ObjectId BDCCAPDCEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B1FED0", Offset = "0x2B1E6D0", VA = "0x182B1FED0", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B20190", Offset = "0x2B1E990", VA = "0x182B20190", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B202F0", Offset = "0x2B1EAF0", VA = "0x182B202F0", Slot = "10")]
	public void JGEAHDMNOIJ(ObjectId BDCCAPDCEBB, bool DAPFKCHACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2D47C10", Offset = "0x2D46410", VA = "0x182D47C10")]
	public void OLNPCCKHJMN<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B1FF50", Offset = "0x2B1E750", VA = "0x182B1FF50")]
	private SortedDictionary<DODAPBIEPCA, IKCIBAKICFC> DGHLMHMBPPO(ObjectId BDCCAPDCEBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2B20470", Offset = "0x2B1EC70", VA = "0x182B20470")]
	public AHCEDHJCFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2D47BE0", Offset = "0x2D463E0", VA = "0x182D47BE0", Slot = "11")]
	private void GCLOCHBFLGO<T>(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, in T HNCFAALBJCG, bool DAPFKCHACNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GOKJLLJGIHM : KGBBJBIGNDI.NEAKHFIENLA, JMBMAEJAFOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private EDBKJCPEKAL NEJIONOIEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AFCILMMABCK MEPFNOBDHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CancellationTokenSource AAGLFEKLEOM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public global::EELEHNJLJKC<JNJCHABBGGJ, GPOPJFOCHAM> BFBAJNBBLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x50B460", Offset = "0x509C60", VA = "0x18050B460", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D40", Offset = "0x5E2540", VA = "0x1805E3D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private global::EELEHNJLJKC<MOGNIHBNMND, DGCCPGOCGOH> JEMHAMMKGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public sealed override KGCEJBNEOAN DOGMKDAFGIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x75FF00", Offset = "0x75E700", VA = "0x18075FF00", Slot = "9")]
		get
		{
			return default(KGCEJBNEOAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x495CBF0", Offset = "0x495B3F0", VA = "0x18495CBF0", Slot = "6")]
	public sealed override void AELHKPOKINJ(POBOFAIGPBJ POAOKGHJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x495CCB0", Offset = "0x495B4B0", VA = "0x18495CCB0", Slot = "11")]
	public void PJLMMBMACKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x495CD00", Offset = "0x495B500", VA = "0x18495CD00")]
	public GOKJLLJGIHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class IDGDPGNGLAN
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HNNFFMONKFG<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public HNNFFMONKFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3AB96F0", Offset = "0x3AB7EF0", VA = "0x183AB96F0")]
		internal void <GetByteEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3AB97C0", Offset = "0x3AB7FC0", VA = "0x183AB97C0")]
		internal T <GetByteEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JFPNMMJFCFN<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public JFPNMMJFCFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6E80", Offset = "0x3AC5680", VA = "0x183AC6E80")]
		internal void <GetSByteEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F60", Offset = "0x3AC5760", VA = "0x183AC6F60")]
		internal T <GetSByteEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class GADNHBKACEK<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public GADNHBKACEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8A60", Offset = "0x3AB7260", VA = "0x183AB8A60")]
		internal void <GetShortEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8AD0", Offset = "0x3AB72D0", VA = "0x183AB8AD0")]
		internal T <GetShortEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MNNCOJDLDLD<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public MNNCOJDLDLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3AC71A0", Offset = "0x3AC59A0", VA = "0x183AC71A0")]
		internal void <GetUShortEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3AC72E0", Offset = "0x3AC5AE0", VA = "0x183AC72E0")]
		internal T <GetUShortEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class HHCNNAIBFIH<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public HHCNNAIBFIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8B90", Offset = "0x3AB7390", VA = "0x183AB8B90")]
		internal void <GetIntEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3AB8CB0", Offset = "0x3AB74B0", VA = "0x183AB8CB0")]
		internal T <GetIntEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MDHEHDHJBGC<T> where T : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public MDHEHDHJBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x3AC7020", Offset = "0x3AC5820", VA = "0x183AC7020")]
		internal void <GetUIntEnumDelegates>b__0(PNDEHDGDOBH b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x3AC70E0", Offset = "0x3AC58E0", VA = "0x183AC70E0")]
		internal T <GetUIntEnumDelegates>b__1(PNDEHDGDOBH b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3695A70", Offset = "0x3694270", VA = "0x183695A70")]
	public static void MMHBJCKCIJP<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x36957D0", Offset = "0x3693FD0", VA = "0x1836957D0")]
	private static void JHFLJECLDDI<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x36957D0", Offset = "0x3693FD0", VA = "0x1836957D0")]
	private static void FLBANHDAEED<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3695E50", Offset = "0x3694650", VA = "0x183695E50")]
	private static void MOCJLMCNJBI<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3695E50", Offset = "0x3694650", VA = "0x183695E50")]
	private static void MPIBKPNJIIB<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x3695530", Offset = "0x3693D30", VA = "0x183695530")]
	private static void DFJALNMAKJK<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3695530", Offset = "0x3693D30", VA = "0x183695530")]
	private static void OOELPADHELB<T>(T HCNLLMNMBJJ, T GLCPDOBBLPE, out global::MLMFHPDLJLE<T> IPOEPJGJFIM, out global::IKKEHKDEAME<T> JPHJPMOOMBI) where T : Enum
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class OJKBPECDJGI
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x495F0C0", Offset = "0x495D8C0", VA = "0x18495F0C0")]
	public static void BLDCPKEJNOG(this PNDEHDGDOBH EKBADBPPBLL, ReadOnlyMemory<byte> GBMCBBKCKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x3838BC0", Offset = "0x38373C0", VA = "0x183838BC0")]
	public static void MIPNPDFGNIA<T>(this PNDEHDGDOBH EKBADBPPBLL, in T HNCFAALBJCG) where T : struct, ELKJLIHADOP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BBDD40", Offset = "0x2BBC540", VA = "0x182BBDD40")]
	public static T OJGEFMOALKD<T>(this PNDEHDGDOBH EKBADBPPBLL) where T : struct, ELKJLIHADOP
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x495F140", Offset = "0x495D940", VA = "0x18495F140")]
	public static void MIPNPDFGNIA(this PNDEHDGDOBH EKBADBPPBLL, OKAKAADJMMJ MOGKBDHNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x495F090", Offset = "0x495D890", VA = "0x18495F090")]
	public static OKAKAADJMMJ ALLLPILJPFC(this PNDEHDGDOBH EKBADBPPBLL)
	{
		return default(OKAKAADJMMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x495F170", Offset = "0x495D970", VA = "0x18495F170")]
	public static void MIPNPDFGNIA(this PNDEHDGDOBH EKBADBPPBLL, KHPEONHGFHL PFMJOAEMNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x495F1A0", Offset = "0x495D9A0", VA = "0x18495F1A0")]
	public static KHPEONHGFHL PPBGFHAOKJL(this PNDEHDGDOBH EKBADBPPBLL)
	{
		return default(KHPEONHGFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3838AF0", Offset = "0x38372F0", VA = "0x183838AF0")]
	public static void BOIFOOJONCC<ObjectId>(this PNDEHDGDOBH EKBADBPPBLL, in DODAPBIEPCA PFMJOAEMNFL) where ObjectId : struct, BBHDKPAHPDH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF2320", Offset = "0x2AF0B20", VA = "0x182AF2320")]
	public static DODAPBIEPCA DIEIGNKDMJG<ObjectId>(this PNDEHDGDOBH EKBADBPPBLL) where ObjectId : struct, BBHDKPAHPDH
	{
		return default(DODAPBIEPCA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GONKHBMBCBD
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3694430", Offset = "0x3692C30", VA = "0x183694430")]
	public static void MIANMBLOFGN<T>(this FPFKNDBFEBA AKPJLEFOMKG, global::MLMFHPDLJLE<T> ELLILLBFBNO, global::IKKEHKDEAME<T> CLIOMFFMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x36941D0", Offset = "0x36929D0", VA = "0x1836941D0")]
	public static void GGNIOLADAFG<T>(this FPFKNDBFEBA AKPJLEFOMKG, T HCNLLMNMBJJ, T GLCPDOBBLPE) where T : Enum
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3694460", Offset = "0x3692C60", VA = "0x183694460")]
	public static void PHGDMELDKMG<T>(this FPFKNDBFEBA AKPJLEFOMKG) where T : struct, ELKJLIHADOP
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public struct GOFIHEFGBJO<ObjectId> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public ObjectId BDCCAPDCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public DODAPBIEPCA AMHMKDHPKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public object ODIPMNFKGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public object HDGPOJDDNJO;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2BDED80", Offset = "0x2BDD580", VA = "0x182BDED80")]
	public GOFIHEFGBJO(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, object ODIPMNFKGLE, object HDGPOJDDNJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class LDOECEJPBIM<ObjectId> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public delegate void OPIGLNNCGDE(ObjectId BDCCAPDCEBB);

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate void GBEBFNHCABC(ObjectId BDCCAPDCEBB);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate void PBNKFKJDCLM(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, object HNCFAALBJCG);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate object NBCGBAAGDBN(ObjectId BDCCAPDCEBB, DODAPBIEPCA AMHMKDHPKHP, object OOGAPICNMPD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Deque<global::GMJFDNHCIPL<ObjectId>> KIJIMACKNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private PBNKFKJDCLM PHELGOFIGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private NBCGBAAGDBN LDEHAGAIHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private GBEBFNHCABC CHPNMOKFEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private OPIGLNNCGDE INKLPBOEHNG;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7130", Offset = "0x3BD5930", VA = "0x183BD7130")]
	public LDOECEJPBIM(PBNKFKJDCLM PHELGOFIGAC, [Optional] NBCGBAAGDBN LDEHAGAIHHE, [Optional] GBEBFNHCABC CHPNMOKFEFE, [Optional] OPIGLNNCGDE INKLPBOEHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3BD5E50", Offset = "0x3BD4650", VA = "0x183BD5E50")]
	public void GJBKNPLMEOE(ObjectId BDCCAPDCEBB, Dictionary<DODAPBIEPCA, object> IJEJGOMPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7FB0", Offset = "0x2AC67B0", VA = "0x182AC7FB0")]
	public void FMAHHIGMIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3BD7050", Offset = "0x3BD5850", VA = "0x183BD7050")]
	public void MFDJFDLHFHG(global::GOFIHEFGBJO<ObjectId> HPPFCEEDPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x36FD1D0", Offset = "0x36FB9D0", VA = "0x1836FD1D0")]
	public void MFDJFDLHFHG(global::GMJFDNHCIPL<ObjectId> IGHGBPLMDGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class GMJFDNHCIPL<ObjectId> where ObjectId : struct, BBHDKPAHPDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Deque<global::GOFIHEFGBJO<ObjectId>> MJFMHGDAMBC;

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2BDD5B0", Offset = "0x2BDBDB0", VA = "0x182BDD5B0")]
	public GMJFDNHCIPL()
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
