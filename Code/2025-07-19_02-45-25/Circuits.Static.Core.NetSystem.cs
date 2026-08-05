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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A5AF30", Offset = "0x2A59F30", VA = "0x182A5AF30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MOBOOAIANID : NFLHKGJKCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AF00", Offset = "0x2A59F00", VA = "0x182A5AF00", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AEA0", Offset = "0x2A59EA0", VA = "0x182A5AEA0")]
	private MOBOOAIANID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AEB0", Offset = "0x2A59EB0", VA = "0x182A5AEB0")]
	public static MOBOOAIANID MPFKOOIPONO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BAPEHCMPDFC<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, OIFBKIFNHME.IAPGCNNAHDF<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DKBODKDBHJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] DMMJEKIEFHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int DCNPIMAHAPM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x12FAD30", Offset = "0x12F9D30", VA = "0x1812FAD30")]
		private DKBODKDBHJG(TPartialAction[] PDDMKGNMLJC, int PIFKDNFMAOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E9CCF0", Offset = "0x6E9BCF0", VA = "0x186E9CCF0")]
		public static BAPEHCMPDFC<TPartialAction, TPartialActionId, TFullAction, TDeps>.DKBODKDBHJG MPFKOOIPONO(int FHKNFHFNEFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E9C9C0", Offset = "0x6E9B9C0", VA = "0x186E9C9C0")]
		public ILFGODFHMHE<TFullAction> CPFJMNMNLBL(TPartialAction LHGIDBMONEI, TDeps APEKGFIAPNC)
		{
			return default(ILFGODFHMHE<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, DKBODKDBHJG>? MJOPKOGMDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps AEIHNHECOOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, DKBODKDBHJG> MDOGLJDNMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x633BE10", Offset = "0x633AE10", VA = "0x18633BE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x633BEF0", Offset = "0x633AEF0", VA = "0x18633BEF0")]
	private BAPEHCMPDFC(Dictionary<TPartialActionId, DKBODKDBHJG>? PMBBLGIGFDH, TDeps APEKGFIAPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x633BD60", Offset = "0x633AD60", VA = "0x18633BD60")]
	public static BAPEHCMPDFC<TPartialAction, TPartialActionId, TFullAction, TDeps> MPFKOOIPONO(TDeps APEKGFIAPNC)
	{
		return default(BAPEHCMPDFC<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x633B780", Offset = "0x633A780", VA = "0x18633B780")]
	public DAFIFKKNPFP<ILFGODFHMHE<TFullAction>, AGMCGONFHKP> CPFJMNMNLBL(TPartialAction LHGIDBMONEI)
	{
		return default(DAFIFKKNPFP<ILFGODFHMHE<TFullAction>, AGMCGONFHKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x633AF60", Offset = "0x6339F60", VA = "0x18633AF60")]
	public void BFJNPMMKIFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OIFBKIFNHME
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface IAPGCNNAHDF<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BHHGBNNLNIA([In] TPartialAction LHGIDBMONEI);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int MJHKOJAEAFD([In] TPartialAction LHGIDBMONEI);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId MCGPMKGEKOF([In] TPartialAction LHGIDBMONEI);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction LJCDPJCNOJC(TPartialAction[] JICDIAHICBN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OBCPDLECAHL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : OOKDFJPJPPN.EDAHAAAKNFP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] BCHMFNIDOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int CMCMDCFPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps AEIHNHECOOB;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5897E90", Offset = "0x5896E90", VA = "0x185897E90")]
	internal OBCPDLECAHL(TPartialSnapshot[] IFHHJKKJPCA, int DOFOIKLGDDD, TDeps APEKGFIAPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5897E30", Offset = "0x5896E30", VA = "0x185897E30")]
	public static OBCPDLECAHL<TPartialSnapshot, TFullSnapshot, TDeps> MPFKOOIPONO(TDeps APEKGFIAPNC)
	{
		return default(OBCPDLECAHL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OOKDFJPJPPN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface EDAHAAAKNFP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CPGBGGELBIP([In] TPartialSnapshot CGPHMHKFDFI);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot DFIDCFMHPAI(TPartialSnapshot[] IGPJGDGJLIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3E300C0", Offset = "0x3E2F0C0", VA = "0x183E300C0")]
	public static ILFGODFHMHE<TFullSnapshot> CPFJMNMNLBL<TFullSnapshot, TPartialSnapshot, TDeps>(this OBCPDLECAHL<TPartialSnapshot, TFullSnapshot, TDeps> OLHDOIOOPGE, TPartialSnapshot CGPHMHKFDFI) where TDeps : EDAHAAAKNFP<TPartialSnapshot, TFullSnapshot>
	{
		return default(ILFGODFHMHE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3E30470", Offset = "0x3E2F470", VA = "0x183E30470")]
	public static bool HDIOBAEILLH<TPartialSnapshot, TFullSnapshot, TDeps>(this OBCPDLECAHL<TPartialSnapshot, TFullSnapshot, TDeps> OLHDOIOOPGE, TPartialSnapshot CGPHMHKFDFI) where TDeps : EDAHAAAKNFP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class BNPCDCCAHHO : NFLHKGJKCPB
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AE70", Offset = "0x2A59E70", VA = "0x182A5AE70", Slot = "7")]
	public override string OFBAEHEOPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AEA0", Offset = "0x2A59EA0", VA = "0x182A5AEA0")]
	public BNPCDCCAHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : CMJLOOFPGDI.NGNHNCCHOKL<TAction, TNetSys> where TReceiverDeps : CMJLOOFPGDI.POMDOJCFFOI<TAction, TReceiver> where TRootDeps : CMJLOOFPGDI.IMFJKNHCPNM<TAction, TRoot> where TDeps : CMJLOOFPGDI.KGPAJJPHDDD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface DEPHDGBEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CJDKCLMDGCP([In] DAFIFKKNPFP<object, AGMCGONFHKP> BGOCMPMGKKI);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DAFIFKKNPFP<object, AGMCGONFHKP> BNJEBOMMJCH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class AKIJBNIMGMO : DEPHDGBEMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly List<DAFIFKKNPFP<object, BJPMMCEJAGH>> GNOENAAHMLM;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x526CD80", Offset = "0x526BD80", VA = "0x18526CD80")]
		public static AKIJBNIMGMO MPFKOOIPONO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x526CB80", Offset = "0x526BB80", VA = "0x18526CB80")]
		public void CJDKCLMDGCP([In] DAFIFKKNPFP<object, AGMCGONFHKP> BGOCMPMGKKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x526C870", Offset = "0x526B870", VA = "0x18526C870", Slot = "5")]
		public DAFIFKKNPFP<object, AGMCGONFHKP> BNJEBOMMJCH()
		{
			return default(DAFIFKKNPFP<object, AGMCGONFHKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x526CEC0", Offset = "0x526BEC0", VA = "0x18526CEC0")]
		public AKIJBNIMGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4DAED20", Offset = "0x4DADD20", VA = "0x184DAED20", Slot = "4")]
		private void AHIEMKNEFAJ([In] DAFIFKKNPFP<object, AGMCGONFHKP> BGOCMPMGKKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class CIFCGOKKFLH : DEPHDGBEMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private DAFIFKKNPFP<object, AGMCGONFHKP> BKHPKKGCEBE;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x526CD80", Offset = "0x526BD80", VA = "0x18526CD80")]
		public static CIFCGOKKFLH MPFKOOIPONO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2625800", Offset = "0x2624800", VA = "0x182625800")]
		public void CJDKCLMDGCP([In] DAFIFKKNPFP<object, AGMCGONFHKP> BGOCMPMGKKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60", Slot = "5")]
		public DAFIFKKNPFP<object, AGMCGONFHKP> BNJEBOMMJCH()
		{
			return default(DAFIFKKNPFP<object, AGMCGONFHKP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CIFCGOKKFLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4DAED20", Offset = "0x4DADD20", VA = "0x184DAED20", Slot = "4")]
		private void AHIEMKNEFAJ([In] DAFIFKKNPFP<object, AGMCGONFHKP> BGOCMPMGKKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct EIBOLPHOBNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4904090", Offset = "0x4903090", VA = "0x184904090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4904900", Offset = "0x4903900", VA = "0x184904900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EAILMHPNHJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x48E6900", Offset = "0x48E5900", VA = "0x1848E6900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x48E6E10", Offset = "0x48E5E10", VA = "0x1848E6E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct BOLGJPHOKOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6529DC0", Offset = "0x6528DC0", VA = "0x186529DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x652A520", Offset = "0x6529520", VA = "0x18652A520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct ICMLEOOHEGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private DEPHDGBEMPD <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50099A0", Offset = "0x50089A0", VA = "0x1850099A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x500BCC0", Offset = "0x500ACC0", VA = "0x18500BCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct DODHKOHMDFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DEPHDGBEMPD completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private DEPHDGBEMPD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x44A09D0", Offset = "0x449F9D0", VA = "0x1844A09D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x44A27E0", Offset = "0x44A17E0", VA = "0x1844A27E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct CFNDDEHCDKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68B7000", Offset = "0x68B6000", VA = "0x1868B7000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x68B7AF0", Offset = "0x68B6AF0", VA = "0x1868B7AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps AEIHNHECOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool MKNMKMMMDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int AAPKPNELGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task HHFLDODBPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int KDMLHCAKGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int KMKPILNFEOB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps MDHDMLKECMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4DBDBB0", Offset = "0x4DBCBB0", VA = "0x184DBDBB0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps NDAFNMOCLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFD90", Offset = "0x4DBED90", VA = "0x184DBFD90")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps LFIACKPMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4DBFDC0", Offset = "0x4DBEDC0", VA = "0x184DBFDC0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool LFAODGPIPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB3C180", Offset = "0xB3B180", VA = "0x180B3C180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB3C190", Offset = "0xB3B190", VA = "0x180B3C190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DHMIAHEPFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BPBHBDINKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EIIOHEOHPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC333D0", Offset = "0xC323D0", VA = "0x180C333D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1360", Offset = "0x4DC0360", VA = "0x184DC1360")]
	public FOOMECEDINO(TDeps APEKGFIAPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4DC0100", Offset = "0x4DBF100", VA = "0x184DC0100")]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, TNetSys PNKPFKDPDCL, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB, bool HANGNDPHGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x4DBFFA0", Offset = "0x4DBEFA0", VA = "0x184DBFFA0")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.EIBOLPHOBNJ))]
	private Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDC30", Offset = "0x4DBCC30", VA = "0x184DBDC30")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.EAILMHPNHJB))]
	private Task<DAFIFKKNPFP<object, AGMCGONFHKP>> FBLBCNEIIKE(TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction[] LKAGMPJGIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE630", Offset = "0x4DBD630", VA = "0x184DBE630")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.BOLGJPHOKOG))]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> IBLOHAMGFPN(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4DBE350", Offset = "0x4DBD350", VA = "0x184DBE350")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.ICMLEOOHEGF))]
	private Task<DAFIFKKNPFP<object, AGMCGONFHKP>> HOMBBCMKALB(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB, Task LDJGICDAGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4DBEBB0", Offset = "0x4DBDBB0", VA = "0x184DBEBB0")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.DODHKOHMDFD))]
	private Task KHBHKLDEMNL(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, TAction DMHPHEGJKMB, DEPHDGBEMPD KEPMAEPHNAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4DBDAA0", Offset = "0x4DBCAA0", VA = "0x184DBDAA0")]
	private void ABOAALLGHML(TReceiver GEBKONJKJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4DBF250", Offset = "0x4DBE250", VA = "0x184DBF250")]
	private void KJEIDCIFAIH(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB, bool MCKHANPBFCL, bool CJIAJMDICEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4DBFAC0", Offset = "0x4DBEAC0", VA = "0x184DBFAC0")]
	[AsyncStateMachine(typeof(FOOMECEDINO<, , , , , , , >.CFNDDEHCDKI))]
	public Task KLGFKKOBJDJ(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction[] ANOCEDEMHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4DC1010", Offset = "0x4DC0010", VA = "0x184DC1010")]
	private (TAction, int) OABKOMEGDCK(TRoot NKBKNNLLHKF, TNetSys LHLGFGMPHLL, TAction DMHPHEGJKMB)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class CMJLOOFPGDI
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface NGNHNCCHOKL<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MAFNDLJCPJM(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction KLMHAFEOIJG(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction GMBMNJNFHJA(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> GPFKGHGPKOF(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] NCDJDAKODIE(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB, int CFAHGDOFMLM);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HCFCAKEKOIM(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool GIIBDNCGJGC(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BDLCAOGPMBH(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IDIENIKLCGF(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DJMLHBLMHMO(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NNJIACLIAIL(TNetSys CBDDKAMCOJI, TAction DMHPHEGJKMB);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface KGPAJJPHDDD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TActionDeps MDHDMLKECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TReceiverDeps LFIACKPMCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		TRootDeps NDAFNMOCLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface POMDOJCFFOI<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OCIDMCEKJIP<HHMPHBFPOIN> OMLHDFAOOKF(TReceiver GEBKONJKJPJ);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IPAEFPOOJCC(TReceiver GEBKONJKJPJ);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<DAFIFKKNPFP<object, AGMCGONFHKP>> IBLOHAMGFPN(TReceiver GEBKONJKJPJ, TAction DMHPHEGJKMB);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] HMKJPGKIFEI(TReceiver GEBKONJKJPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface IMFJKNHCPNM<TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IBOOGNCNGJK(TRoot NKBKNNLLHKF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KHBMHHKCMAE(TRoot NKBKNNLLHKF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MCPGAHOJABP(TRoot NKBKNNLLHKF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BNENPCHIJPP(TRoot NKBKNNLLHKF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LIEDGHBCDCP(TRoot NKBKNNLLHKF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GIFIALCKBCM(TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction[] LKAGMPJGIBJ);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool IDDJNJNGPCO(TRoot NKBKNNLLHKF, int HGGKPAOPMOH);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB, bool PJDBKLOFGEG = true);
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
