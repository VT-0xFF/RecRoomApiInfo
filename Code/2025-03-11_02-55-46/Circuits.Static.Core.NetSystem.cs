using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x25DE020", Offset = "0x25DD420", VA = "0x1825DE020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEFIOLKHEBB : MJOPIANFEAH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x25DDF90", Offset = "0x25DD390", VA = "0x1825DDF90", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25DE010", Offset = "0x25DD410", VA = "0x1825DE010")]
	private HEFIOLKHEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25DDFC0", Offset = "0x25DD3C0", VA = "0x1825DDFC0")]
	public static HEFIOLKHEBB KMDIICJFNJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NNFFDCFDMAK<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, JGFNJLKGLAK.GBMHIDDOGED<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EHIJCHPDFBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] APPLIDKGCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int AACIBKPCMKM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x100FF80", Offset = "0x100F380", VA = "0x18100FF80")]
		private EHIJCHPDFBD(TPartialAction[] PKNGJDNGFGA, int AFNGEGFJBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x411F6A0", Offset = "0x411EAA0", VA = "0x18411F6A0")]
		public static NNFFDCFDMAK<TPartialAction, TPartialActionId, TFullAction, TDeps>.EHIJCHPDFBD KMDIICJFNJF(int ALDJJICHKGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x411F9F0", Offset = "0x411EDF0", VA = "0x18411F9F0")]
		public CCAOJCEHJPO<TFullAction> OPACIGNBONE(TPartialAction PIOJPAPNDDP, TDeps BDKFMFBFJII)
		{
			return default(CCAOJCEHJPO<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, EHIJCHPDFBD>? HEGBODMLBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, EHIJCHPDFBD> DELHPCPOBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4E93AC0", Offset = "0x4E92EC0", VA = "0x184E93AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E94BE0", Offset = "0x4E93FE0", VA = "0x184E94BE0")]
	private NNFFDCFDMAK(Dictionary<TPartialActionId, EHIJCHPDFBD>? ILGFENPKPOB, TDeps BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E93BB0", Offset = "0x4E92FB0", VA = "0x184E93BB0")]
	public static NNFFDCFDMAK<TPartialAction, TPartialActionId, TFullAction, TDeps> KMDIICJFNJF(TDeps BDKFMFBFJII)
	{
		return default(NNFFDCFDMAK<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E93D20", Offset = "0x4E93120", VA = "0x184E93D20")]
	public PHLGGJNOBDN<CCAOJCEHJPO<TFullAction>, MEENKFHCKIP> OPACIGNBONE(TPartialAction PIOJPAPNDDP)
	{
		return default(PHLGGJNOBDN<CCAOJCEHJPO<TFullAction>, MEENKFHCKIP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E93C60", Offset = "0x4E93060", VA = "0x184E93C60")]
	public void LHOCJMEKDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JGFNJLKGLAK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GBMHIDDOGED<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PHBLALAAOOB([In] TPartialAction PIOJPAPNDDP);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OKKKLBLHMGH([In] TPartialAction PIOJPAPNDDP);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId HCIMNAPCJBL([In] TPartialAction PIOJPAPNDDP);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction AHOPDPELKDN(TPartialAction[] AJOOLJIDONH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NEOHKIFFOFG<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CJJMGPLBDGB.MIDCCPFOFNM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] KCLHBPNHJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int IDFFMNFLGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D8B0", Offset = "0x4E7CCB0", VA = "0x184E7D8B0")]
	internal NEOHKIFFOFG(TPartialSnapshot[] IGKAOIDGKLH, int GCCMKDKOICG, TDeps BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4E7D7E0", Offset = "0x4E7CBE0", VA = "0x184E7D7E0")]
	public static NEOHKIFFOFG<TPartialSnapshot, TFullSnapshot, TDeps> KMDIICJFNJF(TDeps BDKFMFBFJII)
	{
		return default(NEOHKIFFOFG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class CJJMGPLBDGB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface MIDCCPFOFNM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EACNHMOLILI([In] TPartialSnapshot BGDLHIAOBHD);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ELMOOMEKDLJ(TPartialSnapshot[] NFAFLNGCFIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x327EAC0", Offset = "0x327DEC0", VA = "0x18327EAC0")]
	public static CCAOJCEHJPO<TFullSnapshot> OPACIGNBONE<TFullSnapshot, TPartialSnapshot, TDeps>(this NEOHKIFFOFG<TPartialSnapshot, TFullSnapshot, TDeps> IIICNLIAPBJ, TPartialSnapshot BGDLHIAOBHD) where TDeps : MIDCCPFOFNM<TPartialSnapshot, TFullSnapshot>
	{
		return default(CCAOJCEHJPO<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x327E840", Offset = "0x327DC40", VA = "0x18327E840")]
	public static bool FLJGHPKLFGK<TPartialSnapshot, TFullSnapshot, TDeps>(this NEOHKIFFOFG<TPartialSnapshot, TFullSnapshot, TDeps> IIICNLIAPBJ, TPartialSnapshot BGDLHIAOBHD) where TDeps : MIDCCPFOFNM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PDPEMGMHHGD : MJOPIANFEAH
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x25DE0A0", Offset = "0x25DD4A0", VA = "0x1825DE0A0", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x25DE010", Offset = "0x25DD410", VA = "0x1825DE010")]
	public PDPEMGMHHGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JPKEPBEMGCD.FFIMPOKJGII<TAction, TNetSys> where TReceiverDeps : JPKEPBEMGCD.EECJLCDFHNE<TAction, TReceiver> where TRootDeps : JPKEPBEMGCD.FPIDBBHPCDI<TMRequest, TAction, TRoot> where TDeps : JPKEPBEMGCD.IANFBIBNMDF<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface JCGAMACLLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HJFDLKHCCIM([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ILKLLCJMHHK();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PHLGGJNOBDN<object, MEENKFHCKIP> AMIHHNMGLPF();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KLEFPMJAKKB(Exception BOKONMFPKMC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class GEHKCLMFCPA : JCGAMACLLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> JLODPLJHEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<PHLGGJNOBDN<object, MOCCGNOLGDK>> LJIENALCJON;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4657040", Offset = "0x4656440", VA = "0x184657040")]
		private GEHKCLMFCPA(TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> BIBGJEOCDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4656ED0", Offset = "0x46562D0", VA = "0x184656ED0")]
		public static GEHKCLMFCPA KMDIICJFNJF(TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> BIBGJEOCDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4656A10", Offset = "0x4655E10", VA = "0x184656A10")]
		public void HJFDLKHCCIM([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4656D30", Offset = "0x4656130", VA = "0x184656D30", Slot = "5")]
		public void ILKLLCJMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4656870", Offset = "0x4655C70", VA = "0x184656870", Slot = "6")]
		public PHLGGJNOBDN<object, MEENKFHCKIP> AMIHHNMGLPF()
		{
			return default(PHLGGJNOBDN<object, MEENKFHCKIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4656E10", Offset = "0x4656210", VA = "0x184656E10", Slot = "7")]
		public void KLEFPMJAKKB(Exception BOKONMFPKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x46569D0", Offset = "0x4655DD0", VA = "0x1846569D0", Slot = "4")]
		private void BCNMMJJJMKB([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class LGAIPAMDLJN : JCGAMACLLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> JLODPLJHEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PHLGGJNOBDN<object, MEENKFHCKIP> JBKLLNIEBLF;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96D760", Offset = "0x96CB60", VA = "0x18096D760")]
		private LGAIPAMDLJN(TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> BIBGJEOCDEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4656ED0", Offset = "0x46562D0", VA = "0x184656ED0")]
		public static LGAIPAMDLJN KMDIICJFNJF(TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> BIBGJEOCDEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4BF0ED0", Offset = "0x4BF02D0", VA = "0x184BF0ED0")]
		public void HJFDLKHCCIM([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4BF0F50", Offset = "0x4BF0350", VA = "0x184BF0F50", Slot = "5")]
		public void ILKLLCJMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF40", Offset = "0xAFA340", VA = "0x180AFAF40", Slot = "6")]
		public PHLGGJNOBDN<object, MEENKFHCKIP> AMIHHNMGLPF()
		{
			return default(PHLGGJNOBDN<object, MEENKFHCKIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4BF0FB0", Offset = "0x4BF03B0", VA = "0x184BF0FB0", Slot = "7")]
		public void KLEFPMJAKKB(Exception BOKONMFPKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x46569D0", Offset = "0x4655DD0", VA = "0x1846569D0", Slot = "4")]
		private void BCNMMJJJMKB([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class PNNDELADPFG : JCGAMACLLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<PHLGGJNOBDN<object, MEENKFHCKIP>> LJIENALCJON;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50D7CB0", Offset = "0x50D70B0", VA = "0x1850D7CB0")]
		private PNNDELADPFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4657180", Offset = "0x4656580", VA = "0x184657180")]
		public static PNNDELADPFG KMDIICJFNJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50D7AA0", Offset = "0x50D6EA0", VA = "0x1850D7AA0")]
		public void HJFDLKHCCIM([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void ILKLLCJMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x50D7960", Offset = "0x50D6D60", VA = "0x1850D7960", Slot = "6")]
		public PHLGGJNOBDN<object, MEENKFHCKIP> AMIHHNMGLPF()
		{
			return default(PHLGGJNOBDN<object, MEENKFHCKIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x50D7B80", Offset = "0x50D6F80", VA = "0x1850D7B80", Slot = "7")]
		[FDIEMNELNCN("This may be terminal and should probably do more than discarding the exception.")]
		public void KLEFPMJAKKB(Exception BOKONMFPKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x46569D0", Offset = "0x4655DD0", VA = "0x1846569D0", Slot = "4")]
		private void BCNMMJJJMKB([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class GEICIKGOGPJ : JCGAMACLLHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private PHLGGJNOBDN<object, MEENKFHCKIP> JBKLLNIEBLF;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		private GEICIKGOGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4657180", Offset = "0x4656580", VA = "0x184657180")]
		public static GEICIKGOGPJ KMDIICJFNJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x212BF20", Offset = "0x212B320", VA = "0x18212BF20")]
		public void HJFDLKHCCIM([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void ILKLLCJMHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB40EA0", Offset = "0xB402A0", VA = "0x180B40EA0", Slot = "6")]
		public PHLGGJNOBDN<object, MEENKFHCKIP> AMIHHNMGLPF()
		{
			return default(PHLGGJNOBDN<object, MEENKFHCKIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4657130", Offset = "0x4656530", VA = "0x184657130", Slot = "7")]
		[FDIEMNELNCN("This may be terminal and should probably do more than discarding the exception.")]
		public void KLEFPMJAKKB(Exception BOKONMFPKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x46569D0", Offset = "0x4655DD0", VA = "0x1846569D0", Slot = "4")]
		private void BCNMMJJJMKB([In] PHLGGJNOBDN<object, MEENKFHCKIP> HOCIBOCHCFJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MIMKCLKHIFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public DDIPAIMAGGM<OBONIKDKABJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4E03170", Offset = "0x4E02570", VA = "0x184E03170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4E03BE0", Offset = "0x4E02FE0", VA = "0x184E03BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KLCBILFIHEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public DDIPAIMAGGM<OBONIKDKABJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4B34D40", Offset = "0x4B34140", VA = "0x184B34D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4B35670", Offset = "0x4B34A70", VA = "0x184B35670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LPKADBOEDLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DDIPAIMAGGM<OBONIKDKABJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DDIPAIMAGGM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<PHLGGJNOBDN<object, MEENKFHCKIP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4C209D0", Offset = "0x4C1FDD0", VA = "0x184C209D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4C20D40", Offset = "0x4C20140", VA = "0x184C20D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FNHFFEHINBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<PHLGGJNOBDN<object, MEENKFHCKIP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DDIPAIMAGGM<OBONIKDKABJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DDIPAIMAGGM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JCGAMACLLHL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4587130", Offset = "0x4586530", VA = "0x184587130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4587D80", Offset = "0x4587180", VA = "0x184587D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LMHJMEHJGEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public JCGAMACLLHL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JCGAMACLLHL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<PHLGGJNOBDN<object?, MEENKFHCKIP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C182D0", Offset = "0x4C176D0", VA = "0x184C182D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4C1A0E0", Offset = "0x4C194E0", VA = "0x184C1A0E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct EKDGEMPCCFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public MPMFOPAFEFO<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DDIPAIMAGGM<OBONIKDKABJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4124EB0", Offset = "0x41242B0", VA = "0x184124EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4125590", Offset = "0x4124990", VA = "0x184125590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps JPIGDBMGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<DDIPAIMAGGM<TMRequest>, TaskCompletionSource<PHLGGJNOBDN<object, MEENKFHCKIP>>> OHGCPFGMLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private NFFKFAHJPIG<TMRequest> KBEHGFNMCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool CNHPDELGNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int KGKKAKLPHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task JIIGIDPHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int FKMBKEBJJFF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps KJGPAJOPIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4E2CD90", Offset = "0x4E2C190", VA = "0x184E2CD90")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps OKDAKANAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4E2D900", Offset = "0x4E2CD00", VA = "0x184E2D900")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps LFHMMHHLOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4E2CE10", Offset = "0x4E2C210", VA = "0x184E2CE10")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool GOGEBABLDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC0E1E0", Offset = "0xC0D5E0", VA = "0x180C0E1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xC0E5B0", Offset = "0xC0D9B0", VA = "0x180C0E5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FMEDMDMILDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x968340", Offset = "0x967740", VA = "0x180968340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BIGOJGKHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x983DD0", Offset = "0x9831D0", VA = "0x180983DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4E2DDE0", Offset = "0x4E2D1E0", VA = "0x184E2DDE0")]
	public MPMFOPAFEFO(TDeps BDKFMFBFJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4E2BCD0", Offset = "0x4E2B0D0", VA = "0x184E2BCD0")]
	public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> DIKKBIIKMPJ(TRoot HAIKBOLEOOP, TNetSys JFNAMKEKNEF, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction NJNJGNMEACN, bool GIKCANOKEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C0E0", Offset = "0x4E2B4E0", VA = "0x184E2C0E0")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.MIMKCLKHIFH))]
	private Task<PHLGGJNOBDN<object, MEENKFHCKIP>> DIKKBIIKMPJ(TRoot HAIKBOLEOOP, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D510", Offset = "0x4E2C910", VA = "0x184E2D510")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.KLCBILFIHEK))]
	private Task<PHLGGJNOBDN<object, MEENKFHCKIP>> GJEFBMMLGFG(TRoot HAIKBOLEOOP, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction[] LNLIOHBEPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D980", Offset = "0x4E2CD80", VA = "0x184E2D980")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.LPKADBOEDLO))]
	public Task<PHLGGJNOBDN<object, MEENKFHCKIP>> KAMKLFJKEOA(TRoot HAIKBOLEOOP, TNetSys KDLJKFGHDHG, TReceiver DGAEDICPJIG, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, DDIPAIMAGGM<TMRequest> EGEKGCPMEJG, TAction NJNJGNMEACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4E2B9F0", Offset = "0x4E2ADF0", VA = "0x184E2B9F0")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.FNHFFEHINBK))]
	private Task<PHLGGJNOBDN<object, MEENKFHCKIP>> AFLDDKBNGKO(TRoot HAIKBOLEOOP, TNetSys KDLJKFGHDHG, TReceiver DGAEDICPJIG, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, DDIPAIMAGGM<TMRequest> EGEKGCPMEJG, TAction NJNJGNMEACN, Task LNJIJPMBMGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4E2C960", Offset = "0x4E2BD60", VA = "0x184E2C960")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.LMHJMEHJGEG))]
	private Task FJKDIBMONGN(TRoot HAIKBOLEOOP, TNetSys KDLJKFGHDHG, TReceiver DGAEDICPJIG, TAction NJNJGNMEACN, JCGAMACLLHL GKBCOIABDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4E2D880", Offset = "0x4E2CC80", VA = "0x184E2D880")]
	private void GLNJMEGHHPL(TReceiver DGAEDICPJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4E2CE40", Offset = "0x4E2C240", VA = "0x184E2CE40")]
	private void GIJJHDCEBEI(TRoot HAIKBOLEOOP, TNetSys KDLJKFGHDHG, TReceiver DGAEDICPJIG, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction NJNJGNMEACN, bool IGCJGHDAJGD, bool KDKKLNPANHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4E2CC00", Offset = "0x4E2C000", VA = "0x184E2CC00")]
	[AsyncStateMachine(typeof(MPMFOPAFEFO<, , , , , , , , >.EKDGEMPCCFI))]
	public Task FJOMBFMEFFH(TRoot HAIKBOLEOOP, TNetSys KDLJKFGHDHG, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction[] HDJFPMGFCKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class JPKEPBEMGCD
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface FFIMPOKJGII<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JDNLMJDFAFM(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction IAFAFNJHPMC(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OOEPECONFLJ(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ONLCKJAKEOA(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] PGKEJOOAPPB(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN, int FNHKHGHAKHE);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool DDGOKJHNFCP(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DDBHLBMCAKD(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EOAHNNEEMDL(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LHNHNMLOGPB(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool JLOEDNNINAI(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FMMFEKEJAHP(TNetSys FDMNIIJFCMI, TAction NJNJGNMEACN);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface IANFBIBNMDF<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps KJGPAJOPIMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps LFHMMHHLOAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps OKDAKANAKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface EECJLCDFHNE<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DDIPAIMAGGM<OBONIKDKABJ> FDEIMDBGIPL(TReceiver DGAEDICPJIG);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ELGCGOAAPCA(TReceiver DGAEDICPJIG);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PHLGGJNOBDN<object, MEENKFHCKIP>> KAMKLFJKEOA(TReceiver DGAEDICPJIG, TAction NJNJGNMEACN);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] PKMKGCIAFOK(TReceiver DGAEDICPJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface FPIDBBHPCDI<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LPCCDHFONHJ(TRoot HAIKBOLEOOP);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int EIPNLBBMBKL(TRoot HAIKBOLEOOP);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int FEFGDPGGBBG(TRoot HAIKBOLEOOP);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DNBEJACMEJH(TRoot HAIKBOLEOOP);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NCDADFDGCLK(TRoot HAIKBOLEOOP);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OPLAOGOCDBC(TRoot HAIKBOLEOOP, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, TAction[] LNLIOHBEPFC);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task DIKKBIIKMPJ(TRoot HAIKBOLEOOP, DDIPAIMAGGM<OBONIKDKABJ> DODLNPKMBHK, DDIPAIMAGGM<TMRequest> EGEKGCPMEJG, TAction NJNJGNMEACN, bool BOBPBKDNGGI = true);
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
