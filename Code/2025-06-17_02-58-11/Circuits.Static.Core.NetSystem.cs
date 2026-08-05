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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x290ED90", Offset = "0x290D790", VA = "0x18290ED90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PCGDLBMEKPP : NNALLDHJADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x290EE10", Offset = "0x290D810", VA = "0x18290EE10", Slot = "7")]
	public override string BKOEAJIGHJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x290ED80", Offset = "0x290D780", VA = "0x18290ED80")]
	private PCGDLBMEKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x290EE40", Offset = "0x290D840", VA = "0x18290EE40")]
	public static PCGDLBMEKPP FMDOFBCLPJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GHLJDPPPGPF<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, DEMMJIKOGFK.AILKPNHCBHF<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CFJCDMGFIAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] GNEPFNECKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int FHENPDOOECG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x122B680", Offset = "0x122A080", VA = "0x18122B680")]
		private CFJCDMGFIAD(TPartialAction[] PHNIGHGJNNM, int LANADMNDGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6582B90", Offset = "0x6581590", VA = "0x186582B90")]
		public static GHLJDPPPGPF<TPartialAction, TPartialActionId, TFullAction, TDeps>.CFJCDMGFIAD FMDOFBCLPJB(int OENGHFPMCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6582CA0", Offset = "0x65816A0", VA = "0x186582CA0")]
		public ADEFLNKAAIF<TFullAction> KHCPNPCGEAA(TPartialAction MJEABEGDHCP, TDeps BFPFMKIIKBG)
		{
			return default(ADEFLNKAAIF<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, CFJCDMGFIAD>? LOEDFOAMBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, CFJCDMGFIAD> BDBFLIABMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4C4F090", Offset = "0x4C4DA90", VA = "0x184C4F090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FF70", Offset = "0x4C4E970", VA = "0x184C4FF70")]
	private GHLJDPPPGPF(Dictionary<TPartialActionId, CFJCDMGFIAD>? GMCJNGBIHOI, TDeps BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F040", Offset = "0x4C4DA40", VA = "0x184C4F040")]
	public static GHLJDPPPGPF<TPartialAction, TPartialActionId, TFullAction, TDeps> FMDOFBCLPJB(TDeps BFPFMKIIKBG)
	{
		return default(GHLJDPPPGPF<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C4F170", Offset = "0x4C4DB70", VA = "0x184C4F170")]
	public KAFLOHEKGBO<ADEFLNKAAIF<TFullAction>, EOIBCJECGDC> KHCPNPCGEAA(TPartialAction MJEABEGDHCP)
	{
		return default(KAFLOHEKGBO<ADEFLNKAAIF<TFullAction>, EOIBCJECGDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C4FEC0", Offset = "0x4C4E8C0", VA = "0x184C4FEC0")]
	public void NIPJMGBJBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DEMMJIKOGFK
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface AILKPNHCBHF<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KGJFDALGBEF([In] TPartialAction MJEABEGDHCP);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JKILAPLJIFA([In] TPartialAction MJEABEGDHCP);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId NOPEJACDFDL([In] TPartialAction MJEABEGDHCP);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction HHAOJMPNJLB(TPartialAction[] OMHNIKFDLBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct EIJFPPFJFOI<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : BAHONDJBBHP.HIMNEOBBNJA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] LDDGHCCHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int EALDJALBGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x469C7E0", Offset = "0x469B1E0", VA = "0x18469C7E0")]
	internal EIJFPPFJFOI(TPartialSnapshot[] PDOMNIPGJIJ, int JCOGEEEHMCC, TDeps BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x469C710", Offset = "0x469B110", VA = "0x18469C710")]
	public static EIJFPPFJFOI<TPartialSnapshot, TFullSnapshot, TDeps> FMDOFBCLPJB(TDeps BFPFMKIIKBG)
	{
		return default(EIJFPPFJFOI<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BAHONDJBBHP
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HIMNEOBBNJA<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IJBLGFDAJEH([In] TPartialSnapshot FBECGOFCPII);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot PHFMNJOBDAO(TPartialSnapshot[] OPDGICJOHHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x37E83E0", Offset = "0x37E6DE0", VA = "0x1837E83E0")]
	public static ADEFLNKAAIF<TFullSnapshot> KHCPNPCGEAA<TFullSnapshot, TPartialSnapshot, TDeps>(this EIJFPPFJFOI<TPartialSnapshot, TFullSnapshot, TDeps> NMEFAPBBOCD, TPartialSnapshot FBECGOFCPII) where TDeps : HIMNEOBBNJA<TPartialSnapshot, TFullSnapshot>
	{
		return default(ADEFLNKAAIF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x37E8790", Offset = "0x37E7190", VA = "0x1837E8790")]
	public static bool NJMLBJAMNBA<TPartialSnapshot, TFullSnapshot, TDeps>(this EIJFPPFJFOI<TPartialSnapshot, TFullSnapshot, TDeps> NMEFAPBBOCD, TPartialSnapshot FBECGOFCPII) where TDeps : HIMNEOBBNJA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class DIOFKNGKBBA : NNALLDHJADJ
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x290ED50", Offset = "0x290D750", VA = "0x18290ED50", Slot = "7")]
	public override string BKOEAJIGHJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x290ED80", Offset = "0x290D780", VA = "0x18290ED80")]
	public DIOFKNGKBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BKNGMHEAEKI.DOIGJLHHJNF<TAction, TNetSys> where TReceiverDeps : BKNGMHEAEKI.MGICJFBDCKP<TAction, TReceiver> where TRootDeps : BKNGMHEAEKI.PMGCHJOMIJL<TMRequest, TAction, TRoot> where TDeps : BKNGMHEAEKI.BICIKKHEKNO<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface AHOIHLFHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KGDPCLCFCKI([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DOEHHEBALCC();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		KAFLOHEKGBO<object, EOIBCJECGDC> LDPEBABMIEM();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LIAIINFAPAI(Exception AGKNBEAOFAM);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FPOJKMICBMB : AHOIHLFHAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> AGNGJBMDOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<KAFLOHEKGBO<object, NCGHLGNIAEG>> GDIGABLBPDP;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4F80", Offset = "0x4BA3980", VA = "0x184BA4F80")]
		private FPOJKMICBMB(TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> LMMMGOIHAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4B5EB90", Offset = "0x4B5D590", VA = "0x184B5EB90")]
		public static FPOJKMICBMB FMDOFBCLPJB(TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> LMMMGOIHAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4910", Offset = "0x4BA3310", VA = "0x184BA4910")]
		public void KGDPCLCFCKI([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4570", Offset = "0x4BA2F70", VA = "0x184BA4570", Slot = "5")]
		public void DOEHHEBALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4B10", Offset = "0x4BA3510", VA = "0x184BA4B10", Slot = "6")]
		public KAFLOHEKGBO<object, EOIBCJECGDC> LDPEBABMIEM()
		{
			return default(KAFLOHEKGBO<object, EOIBCJECGDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4DE0", Offset = "0x4BA37E0", VA = "0x184BA4DE0", Slot = "7")]
		public void LIAIINFAPAI(Exception AGKNBEAOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4550", Offset = "0x4BA2F50", VA = "0x184BA4550", Slot = "4")]
		private void ALALMHLBPFG([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class NEGPFKNFNPE : AHOIHLFHAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> AGNGJBMDOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private KAFLOHEKGBO<object, EOIBCJECGDC> PJNIFLKMELL;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
		private NEGPFKNFNPE(TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> LMMMGOIHAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4B5EB90", Offset = "0x4B5D590", VA = "0x184B5EB90")]
		public static NEGPFKNFNPE FMDOFBCLPJB(TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> LMMMGOIHAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE384D0", Offset = "0xE36ED0", VA = "0x180E384D0")]
		public void KGDPCLCFCKI([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x54FF2B0", Offset = "0x54FDCB0", VA = "0x1854FF2B0", Slot = "5")]
		public void DOEHHEBALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC9A360", Offset = "0xC98D60", VA = "0x180C9A360", Slot = "6")]
		public KAFLOHEKGBO<object, EOIBCJECGDC> LDPEBABMIEM()
		{
			return default(KAFLOHEKGBO<object, EOIBCJECGDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x54FF3D0", Offset = "0x54FDDD0", VA = "0x1854FF3D0", Slot = "7")]
		public void LIAIINFAPAI(Exception AGKNBEAOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4550", Offset = "0x4BA2F50", VA = "0x184BA4550", Slot = "4")]
		private void ALALMHLBPFG([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class JPIKGPFIKJM : AHOIHLFHAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<KAFLOHEKGBO<object, EOIBCJECGDC>> GDIGABLBPDP;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50C9D80", Offset = "0x50C8780", VA = "0x1850C9D80")]
		private JPIKGPFIKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50C9850", Offset = "0x50C8250", VA = "0x1850C9850")]
		public static JPIKGPFIKJM FMDOFBCLPJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50C99D0", Offset = "0x50C83D0", VA = "0x1850C99D0")]
		public void KGDPCLCFCKI([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void DOEHHEBALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x50C9BD0", Offset = "0x50C85D0", VA = "0x1850C9BD0", Slot = "6")]
		public KAFLOHEKGBO<object, EOIBCJECGDC> LDPEBABMIEM()
		{
			return default(KAFLOHEKGBO<object, EOIBCJECGDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x50C9C90", Offset = "0x50C8690", VA = "0x1850C9C90", Slot = "7")]
		[PNLDDMBLJGN("This may be terminal and should probably do more than discarding the exception.")]
		public void LIAIINFAPAI(Exception AGKNBEAOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4550", Offset = "0x4BA2F50", VA = "0x184BA4550", Slot = "4")]
		private void ALALMHLBPFG([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class BGOJGONIEFG : AHOIHLFHAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KAFLOHEKGBO<object, EOIBCJECGDC> PJNIFLKMELL;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		private BGOJGONIEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x50C9850", Offset = "0x50C8250", VA = "0x1850C9850")]
		public static BGOJGONIEFG FMDOFBCLPJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x24C4190", Offset = "0x24C2B90", VA = "0x1824C4190")]
		public void KGDPCLCFCKI([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
		public void DOEHHEBALCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xDCB0C0", Offset = "0xDC9AC0", VA = "0x180DCB0C0", Slot = "6")]
		public KAFLOHEKGBO<object, EOIBCJECGDC> LDPEBABMIEM()
		{
			return default(KAFLOHEKGBO<object, EOIBCJECGDC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x610EA50", Offset = "0x610D450", VA = "0x18610EA50", Slot = "7")]
		[PNLDDMBLJGN("This may be terminal and should probably do more than discarding the exception.")]
		public void LIAIINFAPAI(Exception AGKNBEAOFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4BA4550", Offset = "0x4BA2F50", VA = "0x184BA4550", Slot = "4")]
		private void ALALMHLBPFG([In] KAFLOHEKGBO<object, EOIBCJECGDC> MGJNMKLFKCJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct HGGLEENKCKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4CF04F0", Offset = "0x4CEEEF0", VA = "0x184CF04F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4CF0EC0", Offset = "0x4CEF8C0", VA = "0x184CF0EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct KBLCEOEKOHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x517ED70", Offset = "0x517D770", VA = "0x18517ED70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x517F210", Offset = "0x517DC10", VA = "0x18517F210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EELOLFHIKKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public EHLNDDDNIPO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<KAFLOHEKGBO<object, EOIBCJECGDC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x468DE50", Offset = "0x468C850", VA = "0x18468DE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x468E910", Offset = "0x468D310", VA = "0x18468E910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LACOLPICBCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<KAFLOHEKGBO<object, EOIBCJECGDC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

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
		public EHLNDDDNIPO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private AHOIHLFHAIO <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x526F520", Offset = "0x526DF20", VA = "0x18526F520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5270C60", Offset = "0x526F660", VA = "0x185270C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IEDEEOFAPPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AHOIHLFHAIO completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private AHOIHLFHAIO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<KAFLOHEKGBO<object?, EOIBCJECGDC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4E41DD0", Offset = "0x4E407D0", VA = "0x184E41DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4E43A30", Offset = "0x4E42430", VA = "0x184E43A30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct AHNCNINJJDB : IAsyncStateMachine
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
		public ONEOPDDILII<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public EHLNDDDNIPO<PKGIIJDCHID> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D97D20", Offset = "0x4D96720", VA = "0x184D97D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D98810", Offset = "0x4D97210", VA = "0x184D98810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps JIMKFPLDKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<EHLNDDDNIPO<TMRequest>, TaskCompletionSource<KAFLOHEKGBO<object, EOIBCJECGDC>>> JFFBOKOEJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AABBJMGEOCB<TMRequest> OJHLBJNFAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool AEPKAAFAIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int CIMFDFMKNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task BHAPMDOKJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int CLMDBLNJION;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps KAOJJJLMNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x569CAF0", Offset = "0x569B4F0", VA = "0x18569CAF0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps LDPPIPIGPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x569F070", Offset = "0x569DA70", VA = "0x18569F070")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps PLGCMHDLLCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x569F620", Offset = "0x569E020", VA = "0x18569F620")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MJFIABNDMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDA7C30", Offset = "0xDA6630", VA = "0x180DA7C30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xDA7C40", Offset = "0xDA6640", VA = "0x180DA7C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LDBOCIDKJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int DOOFIFKEFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x569F790", Offset = "0x569E190", VA = "0x18569F790")]
	public ONEOPDDILII(TDeps BFPFMKIIKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x569D2F0", Offset = "0x569BCF0", VA = "0x18569D2F0")]
	public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CJKMKOILCDN(TRoot ALPBGLGCPNB, TNetSys OCIKIJIBINI, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction KPGBPPBMJJK, bool HNAKPKJPFDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x569DD20", Offset = "0x569C720", VA = "0x18569DD20")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.HGGLEENKCKA))]
	private Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CJKMKOILCDN(TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction KPGBPPBMJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x569E2A0", Offset = "0x569CCA0", VA = "0x18569E2A0")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.KBLCEOEKOHM))]
	private Task<KAFLOHEKGBO<object, EOIBCJECGDC>> ELMLJDOPIEK(TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction[] EIIDPNCCGHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x569CB20", Offset = "0x569B520", VA = "0x18569CB20")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.EELOLFHIKKL))]
	public Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CIBCPJFKCGM(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, EHLNDDDNIPO<TMRequest> EKKOCKBOLHD, TAction KPGBPPBMJJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x569C7A0", Offset = "0x569B1A0", VA = "0x18569C7A0")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.LACOLPICBCE))]
	private Task<KAFLOHEKGBO<object, EOIBCJECGDC>> AMDHFJIONHA(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, EHLNDDDNIPO<TMRequest> EKKOCKBOLHD, TAction KPGBPPBMJJK, Task FCMDJENOKEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x569E400", Offset = "0x569CE00", VA = "0x18569E400")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.IEDEEOFAPPF))]
	private Task EOCODHPBGOJ(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, TAction KPGBPPBMJJK, AHOIHLFHAIO DOIPBLBMPIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x569F560", Offset = "0x569DF60", VA = "0x18569F560")]
	private void NHAFJHBIMJH(TReceiver BGDEMBOCEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x569E800", Offset = "0x569D200", VA = "0x18569E800")]
	private void FJKOJHAIMDA(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, TReceiver BGDEMBOCEKP, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction KPGBPPBMJJK, bool GHKKOLLFLIE, bool IELAPFEDHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x569F240", Offset = "0x569DC40", VA = "0x18569F240")]
	[AsyncStateMachine(typeof(ONEOPDDILII<, , , , , , , , >.AHNCNINJJDB))]
	public Task KBGNCLMLIEJ(TRoot ALPBGLGCPNB, TNetSys NJCDPDIJAME, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction[] ACBDHAABIJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BKNGMHEAEKI
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface DOIGJLHHJNF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CHLGMIHOFMJ(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FGNOIHLKBDL(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OCAGDCJFFFK(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> LPKCFPNNJBJ(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] DFLOBMGPKPJ(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK, int MBDMGJLMFGG);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JOJALEDKCMK(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool ALPDJKABHCJ(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BEHJBOKLNAH(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OFGPFOCLMOP(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AGFDGPKDAMM(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool FONPBLDPOIG(TNetSys EACNBNHBDKI, TAction KPGBPPBMJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface BICIKKHEKNO<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps KAOJJJLMNIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps PLGCMHDLLCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps LDPPIPIGPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface MGICJFBDCKP<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		EHLNDDDNIPO<PKGIIJDCHID> AMKPJJHMLJJ(TReceiver BGDEMBOCEKP);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KADBPFKHOKL(TReceiver BGDEMBOCEKP);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<KAFLOHEKGBO<object, EOIBCJECGDC>> CIBCPJFKCGM(TReceiver BGDEMBOCEKP, TAction KPGBPPBMJJK);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] PIIAODLEOFK(TReceiver BGDEMBOCEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface PMGCHJOMIJL<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DEFOKKFHDHC(TRoot ALPBGLGCPNB);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int PECKCDGNGDH(TRoot ALPBGLGCPNB);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MEDMPFMOEGG(TRoot ALPBGLGCPNB);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CJLDELIOGDK(TRoot ALPBGLGCPNB);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void EENOFGDEPDE(TRoot ALPBGLGCPNB);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HJNJIMOEBKK(TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, TAction[] EIIDPNCCGHD);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task CJKMKOILCDN(TRoot ALPBGLGCPNB, EHLNDDDNIPO<PKGIIJDCHID> GHGIHIAONFM, EHLNDDDNIPO<TMRequest> EKKOCKBOLHD, TAction KPGBPPBMJJK, bool BJCKOLGBNAO = true);
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
