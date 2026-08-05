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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28C2570", Offset = "0x28C1770", VA = "0x1828C2570")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LGNICKCHBIN : DMCEODOALNN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28C24B0", Offset = "0x28C16B0", VA = "0x1828C24B0", Slot = "7")]
	public override string AHCNILBBCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28C2530", Offset = "0x28C1730", VA = "0x1828C2530")]
	private LGNICKCHBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x28C24E0", Offset = "0x28C16E0", VA = "0x1828C24E0")]
	public static LGNICKCHBIN FAHGDJGLLGD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JEOKHGHEPEH<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, FABBLNIGBNL.CDHNNMEIHIG<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HNGJIDKGKPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] MDFCEPAHGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int FJGKAAALPMF;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11D4AD0", Offset = "0x11D3CD0", VA = "0x1811D4AD0")]
		private HNGJIDKGKPB(TPartialAction[] HJDHIAILPGB, int DEEEIAFPPJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4CB3710", Offset = "0x4CB2910", VA = "0x184CB3710")]
		public static JEOKHGHEPEH<TPartialAction, TPartialActionId, TFullAction, TDeps>.HNGJIDKGKPB FAHGDJGLLGD(int FMKHKEAMHMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4CB33E0", Offset = "0x4CB25E0", VA = "0x184CB33E0")]
		public FCJIGKLFFLA<TFullAction> BHKBLLHCKHA(TPartialAction IGHHJOADCHP, TDeps AHPCPGHNHGP)
		{
			return default(FCJIGKLFFLA<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, HNGJIDKGKPB>? BJNJAHMJHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, HNGJIDKGKPB> FOEDPOOKAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x502E790", Offset = "0x502D990", VA = "0x18502E790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x502E9D0", Offset = "0x502DBD0", VA = "0x18502E9D0")]
	private JEOKHGHEPEH(Dictionary<TPartialActionId, HNGJIDKGKPB>? DKJGAGICPBM, TDeps AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x502E8D0", Offset = "0x502DAD0", VA = "0x18502E8D0")]
	public static JEOKHGHEPEH<TPartialAction, TPartialActionId, TFullAction, TDeps> FAHGDJGLLGD(TDeps AHPCPGHNHGP)
	{
		return default(JEOKHGHEPEH<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x502E1B0", Offset = "0x502D3B0", VA = "0x18502E1B0")]
	public DJNAMIFBMIO<FCJIGKLFFLA<TFullAction>, FMHHFFBAGLO> BHKBLLHCKHA(TPartialAction IGHHJOADCHP)
	{
		return default(DJNAMIFBMIO<FCJIGKLFFLA<TFullAction>, FMHHFFBAGLO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x502E920", Offset = "0x502DB20", VA = "0x18502E920")]
	public void NDGOOMGMLGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class FABBLNIGBNL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CDHNNMEIHIG<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LNMJBEFICEA([In] TPartialAction IGHHJOADCHP);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OAPIONIBPLF([In] TPartialAction IGHHJOADCHP);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId BAKNPMHFIBF([In] TPartialAction IGHHJOADCHP);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction EENACGEJGDO(TPartialAction[] ECCIEPCLAFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KPLPEJNGAFC<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : NMIFIHEHNIO.ONGOMPBKFAG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] BFECHMADFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int PGIFFNEJLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x516BF20", Offset = "0x516B120", VA = "0x18516BF20")]
	internal KPLPEJNGAFC(TPartialSnapshot[] EKMHNODNCCE, int JNGKFHIEBNI, TDeps AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x516BE50", Offset = "0x516B050", VA = "0x18516BE50")]
	public static KPLPEJNGAFC<TPartialSnapshot, TFullSnapshot, TDeps> FAHGDJGLLGD(TDeps AHPCPGHNHGP)
	{
		return default(KPLPEJNGAFC<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NMIFIHEHNIO
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface ONGOMPBKFAG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OJBGCOMDPBH([In] TPartialSnapshot MOKLACDDLLH);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot KDJPBEFFKLA(TPartialSnapshot[] BPOGGPHGGCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3B62460", Offset = "0x3B61660", VA = "0x183B62460")]
	public static FCJIGKLFFLA<TFullSnapshot> BHKBLLHCKHA<TFullSnapshot, TPartialSnapshot, TDeps>(this KPLPEJNGAFC<TPartialSnapshot, TFullSnapshot, TDeps> IPOCHJJJBCM, TPartialSnapshot MOKLACDDLLH) where TDeps : ONGOMPBKFAG<TPartialSnapshot, TFullSnapshot>
	{
		return default(FCJIGKLFFLA<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3B62810", Offset = "0x3B61A10", VA = "0x183B62810")]
	public static bool NKMAINPLBJE<TPartialSnapshot, TFullSnapshot, TDeps>(this KPLPEJNGAFC<TPartialSnapshot, TFullSnapshot, TDeps> IPOCHJJJBCM, TPartialSnapshot MOKLACDDLLH) where TDeps : ONGOMPBKFAG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class MOMBNLCKHOH : DMCEODOALNN
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x28C2540", Offset = "0x28C1740", VA = "0x1828C2540", Slot = "7")]
	public override string AHCNILBBCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x28C2530", Offset = "0x28C1730", VA = "0x1828C2530")]
	public MOMBNLCKHOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BKMOEILPCAA.MEMHKBFANIB<TAction, TNetSys> where TReceiverDeps : BKMOEILPCAA.FKKBIIGGPHN<TAction, TReceiver> where TRootDeps : BKMOEILPCAA.EPLNGPJMFNL<TMRequest, TAction, TRoot> where TDeps : BKMOEILPCAA.APNDLGACNJN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface ECJNFGFGKGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NBBFOMKKMDK([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJCMJEOODPF();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DJNAMIFBMIO<object, FMHHFFBAGLO> COPHJPEONPO();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DJAPFLLIDPI(Exception JNDFFCAMALC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class MIBKEFHANOC : ECJNFGFGKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> JKIMBOHBCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<DJNAMIFBMIO<object, JNEBIKAJDEN>> BIADGIHBAAN;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x541FFA0", Offset = "0x541F1A0", VA = "0x18541FFA0")]
		private MIBKEFHANOC(TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> EMLEFEFPNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4C1B420", Offset = "0x4C1A620", VA = "0x184C1B420")]
		public static MIBKEFHANOC FAHGDJGLLGD(TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> EMLEFEFPNEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x541FD00", Offset = "0x541EF00", VA = "0x18541FD00")]
		public void NBBFOMKKMDK([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x541FB20", Offset = "0x541ED20", VA = "0x18541FB20", Slot = "5")]
		public void LJCMJEOODPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x541F6E0", Offset = "0x541E8E0", VA = "0x18541F6E0", Slot = "6")]
		public DJNAMIFBMIO<object, FMHHFFBAGLO> COPHJPEONPO()
		{
			return default(DJNAMIFBMIO<object, FMHHFFBAGLO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x541F8A0", Offset = "0x541EAA0", VA = "0x18541F8A0", Slot = "7")]
		public void DJAPFLLIDPI(Exception JNDFFCAMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F359A0", Offset = "0x4F34BA0", VA = "0x184F359A0", Slot = "4")]
		private void DCBNIFKOPHI([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class CMMCPPKLIMK : ECJNFGFGKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> JKIMBOHBCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private DJNAMIFBMIO<object, FMHHFFBAGLO> DNKBPJCLIKO;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
		private CMMCPPKLIMK(TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> EMLEFEFPNEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4C1B420", Offset = "0x4C1A620", VA = "0x184C1B420")]
		public static CMMCPPKLIMK FAHGDJGLLGD(TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> EMLEFEFPNEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE222A0", Offset = "0xE214A0", VA = "0x180E222A0")]
		public void NBBFOMKKMDK([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x68729B0", Offset = "0x6871BB0", VA = "0x1868729B0", Slot = "5")]
		public void LJCMJEOODPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC6A9E0", Offset = "0xC69BE0", VA = "0x180C6A9E0", Slot = "6")]
		public DJNAMIFBMIO<object, FMHHFFBAGLO> COPHJPEONPO()
		{
			return default(DJNAMIFBMIO<object, FMHHFFBAGLO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68727D0", Offset = "0x68719D0", VA = "0x1868727D0", Slot = "7")]
		public void DJAPFLLIDPI(Exception JNDFFCAMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F359A0", Offset = "0x4F34BA0", VA = "0x184F359A0", Slot = "4")]
		private void DCBNIFKOPHI([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class OBBHJGIJMAA : ECJNFGFGKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly List<DJNAMIFBMIO<object, FMHHFFBAGLO>> BIADGIHBAAN;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x55FC370", Offset = "0x55FB570", VA = "0x1855FC370")]
		private OBBHJGIJMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4F35AB0", Offset = "0x4F34CB0", VA = "0x184F35AB0")]
		public static OBBHJGIJMAA FAHGDJGLLGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x55FC210", Offset = "0x55FB410", VA = "0x1855FC210")]
		public void NBBFOMKKMDK([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void LJCMJEOODPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55FBF20", Offset = "0x55FB120", VA = "0x1855FBF20", Slot = "6")]
		public DJNAMIFBMIO<object, FMHHFFBAGLO> COPHJPEONPO()
		{
			return default(DJNAMIFBMIO<object, FMHHFFBAGLO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x55FBFD0", Offset = "0x55FB1D0", VA = "0x1855FBFD0", Slot = "7")]
		[BCDODNINIGM("This may be terminal and should probably do more than discarding the exception.")]
		public void DJAPFLLIDPI(Exception JNDFFCAMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F359A0", Offset = "0x4F34BA0", VA = "0x184F359A0", Slot = "4")]
		private void DCBNIFKOPHI([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private sealed class AKENABAHGPC : ECJNFGFGKGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DJNAMIFBMIO<object, FMHHFFBAGLO> DNKBPJCLIKO;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		private AKENABAHGPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F35AB0", Offset = "0x4F34CB0", VA = "0x184F35AB0")]
		public static AKENABAHGPC FAHGDJGLLGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2453140", Offset = "0x2452340", VA = "0x182453140")]
		public void NBBFOMKKMDK([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "5")]
		public void LJCMJEOODPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0", Slot = "6")]
		public DJNAMIFBMIO<object, FMHHFFBAGLO> COPHJPEONPO()
		{
			return default(DJNAMIFBMIO<object, FMHHFFBAGLO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4F35A60", Offset = "0x4F34C60", VA = "0x184F35A60", Slot = "7")]
		[BCDODNINIGM("This may be terminal and should probably do more than discarding the exception.")]
		public void DJAPFLLIDPI(Exception JNDFFCAMALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4F359A0", Offset = "0x4F34BA0", VA = "0x184F359A0", Slot = "4")]
		private void DCBNIFKOPHI([In] DJNAMIFBMIO<object, FMHHFFBAGLO> ACALKMLJJOL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct FCIJLICKEIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4B23500", Offset = "0x4B22700", VA = "0x184B23500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4B23A20", Offset = "0x4B22C20", VA = "0x184B23A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HDNNFHGJLPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A2B0", Offset = "0x4C994B0", VA = "0x184C9A2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4C9AFB0", Offset = "0x4C9A1B0", VA = "0x184C9AFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FPIGELGBKIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public KCKEEEOMPIF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4B4B720", Offset = "0x4B4A920", VA = "0x184B4B720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4B4BB50", Offset = "0x4B4AD50", VA = "0x184B4BB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct MPCHLOMLHBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

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
		public KCKEEEOMPIF<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private ECJNFGFGKGC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5431980", Offset = "0x5430B80", VA = "0x185431980", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54324B0", Offset = "0x54316B0", VA = "0x1854324B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FCOCEEIOPOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public ECJNFGFGKGC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ECJNFGFGKGC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4B25EA0", Offset = "0x4B250A0", VA = "0x184B25EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4B2B6A0", Offset = "0x4B2A8A0", VA = "0x184B2B6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct PKEPKJMOEHL : IAsyncStateMachine
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
		public BJJHPIAEFEP<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5700F60", Offset = "0x5700160", VA = "0x185700F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x57012D0", Offset = "0x57004D0", VA = "0x1857012D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<KCKEEEOMPIF<TMRequest>, TaskCompletionSource<DJNAMIFBMIO<object, FMHHFFBAGLO>>> LGFJGOONGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HGHNFAHADCP<TMRequest> KBHFJGFGOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LNDAFAFHOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int LBNEMFIOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Task EPHKGDMAENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private int OJPIEOAEEEA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps OACAACLFFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x619DE60", Offset = "0x619D060", VA = "0x18619DE60")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps LEEPBFIMINO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x619D370", Offset = "0x619C570", VA = "0x18619D370")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps CKDODDPMHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x619D840", Offset = "0x619CA40", VA = "0x18619D840")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KDFHIMOGHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD7FE70", Offset = "0xD7F070", VA = "0x180D7FE70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD803C0", Offset = "0xD7F5C0", VA = "0x180D803C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DEOFLKJJKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA036F0", Offset = "0xA028F0", VA = "0x180A036F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int CEAFEFEIPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7E0", Offset = "0xA1E9E0", VA = "0x180A1F7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x619F350", Offset = "0x619E550", VA = "0x18619F350")]
	public BJJHPIAEFEP(TDeps AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x619E3E0", Offset = "0x619D5E0", VA = "0x18619E3E0")]
	public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NKKNLPIJJDE(TRoot OLEJNEHCCLF, TNetSys IKHJGJPEHCP, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction CJLPDLONOLK, bool BDEEAIOAPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x619EC40", Offset = "0x619DE40", VA = "0x18619EC40")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.FCIJLICKEIE))]
	private Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NKKNLPIJJDE(TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction CJLPDLONOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x619CB80", Offset = "0x619BD80", VA = "0x18619CB80")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.HDNNFHGJLPG))]
	private Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> BIHGBHNLGIN(TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction[] MCCODECMEOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x619F070", Offset = "0x619E270", VA = "0x18619F070")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.FPIGELGBKIH))]
	public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> ONKDNIGPEGJ(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, KCKEEEOMPIF<TMRequest> DLEIIMMOIIE, TAction CJLPDLONOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x619DB10", Offset = "0x619CD10", VA = "0x18619DB10")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.MPCHLOMLHBG))]
	private Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NCODLMDIOGG(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, KCKEEEOMPIF<TMRequest> DLEIIMMOIIE, TAction CJLPDLONOLK, Task CIPJDCDPGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x619D3F0", Offset = "0x619C5F0", VA = "0x18619D3F0")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.FCOCEEIOPOI))]
	private Task ICNICFELHOG(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, TAction CJLPDLONOLK, ECJNFGFGKGC JHMJKLGPOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x619D910", Offset = "0x619CB10", VA = "0x18619D910")]
	private void MHJBEJKGDBB(TReceiver NHMNHKCABDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x619C6C0", Offset = "0x619B8C0", VA = "0x18619C6C0")]
	private void AMMLEHLLCFF(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction CJLPDLONOLK, bool FABEADPDBBE, bool EPBLMFAKKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x619D0F0", Offset = "0x619C2F0", VA = "0x18619D0F0")]
	[AsyncStateMachine(typeof(BJJHPIAEFEP<, , , , , , , , >.PKEPKJMOEHL))]
	public Task GAPCMCEKDBN(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction[] MDHEFKNAFJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class BKMOEILPCAA
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface MEMHKBFANIB<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DKJEGHLPAGA(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction BEDMGDMKLGG(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BEMPBNLGPBM(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OKKGHLEKOLN(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] KJBALIPPEBP(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK, int BLNGBEFEBMP);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool IBKKJMNMMFK(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IAJCFCNDDKD(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool MFDAPMMFFGE(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool GJPLEICKOMA(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GEGKNIPOFJO(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GGGEGAPMACK(TNetSys MMHOIGBMNBB, TAction CJLPDLONOLK);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface APNDLGACNJN<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TActionDeps OACAACLFFFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TReceiverDeps CKDODDPMHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TRootDeps LEEPBFIMINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface FKKBIIGGPHN<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KCKEEEOMPIF<DDJEBBDGHKM> LEOFANAPFIA(TReceiver NHMNHKCABDL);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LBKHGIKLEKC(TReceiver NHMNHKCABDL);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> ONKDNIGPEGJ(TReceiver NHMNHKCABDL, TAction CJLPDLONOLK);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] BCIGGGOPMDL(TReceiver NHMNHKCABDL);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface EPLNGPJMFNL<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BGMGDPMGACI(TRoot OLEJNEHCCLF);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int IBOONCFEKGI(TRoot OLEJNEHCCLF);

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DPIDIMHMJJE(TRoot OLEJNEHCCLF);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int ICPDLCCKEEN(TRoot OLEJNEHCCLF);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PMIPHBFEKEI(TRoot OLEJNEHCCLF);

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KJLNIPFGODA(TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction[] MCCODECMEOL);

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task NKKNLPIJJDE(TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, KCKEEEOMPIF<TMRequest> DLEIIMMOIIE, TAction CJLPDLONOLK, bool KLKDDMMCHIL = true);
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
