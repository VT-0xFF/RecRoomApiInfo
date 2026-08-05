using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FJKPLOAAJMF : CIDEKEMPLEH, AIKJIPIMHLA
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct KVP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string k;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string v;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct KVPs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public KVP[] kvps;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Dictionary<string, string> KGHHDBPCLOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private string HCNLNOGKGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DCFF70", Offset = "0x6DCF370", VA = "0x186DCFF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private Dictionary<string, string> AEKCEBHEBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DD0190", Offset = "0x6DCF590", VA = "0x186DD0190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	[Preserve]
	public FJKPLOAAJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF3D0", Offset = "0x6DCE7D0", VA = "0x186DCF3D0", Slot = "6")]
	public Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF820", Offset = "0x6DCEC20", VA = "0x186DCF820", Slot = "14")]
	public float INKEHDBAJKG(string KOFPKIJDAMC, float OLNFJPNAOBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF490", Offset = "0x6DCE890", VA = "0x186DCF490", Slot = "13")]
	public void BNFEBFAMPLO(string KOFPKIJDAMC, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF6C0", Offset = "0x6DCEAC0", VA = "0x186DCF6C0", Slot = "12")]
	public bool IDLOLHPHMCM(string KOFPKIJDAMC, bool OLNFJPNAOBM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF7B0", Offset = "0x6DCEBB0", VA = "0x186DCF7B0", Slot = "10")]
	public int IGOPLLJIMKI(string KOFPKIJDAMC, int OLNFJPNAOBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFC40", Offset = "0x6DCF040", VA = "0x186DCFC40", Slot = "18")]
	public DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF420", Offset = "0x6DCE820", VA = "0x186DCF420", Slot = "19")]
	public void AKJAFOECPJK(string KOFPKIJDAMC, DateTime KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF00", Offset = "0x6DCF300", VA = "0x186DCFF00", Slot = "15")]
	public void MINIBEBGMIB(string KOFPKIJDAMC, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0070", Offset = "0x6DCF470", VA = "0x186DD0070", Slot = "11")]
	public void OJCHJHFBOPI(string KOFPKIJDAMC, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF500", Offset = "0x6DCE900", VA = "0x186DCF500", Slot = "20")]
	public long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF650", Offset = "0x6DCEA50", VA = "0x186DCF650", Slot = "21")]
	public void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "22")]
	public T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "23")]
	public void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DD00E0", Offset = "0x6DCF4E0", VA = "0x186DD00E0", Slot = "16")]
	public string ONOOJIGOPOK(string KOFPKIJDAMC, string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFBA0", Offset = "0x6DCEFA0", VA = "0x186DCFBA0", Slot = "17")]
	public void KMHPHPGIDFJ(string KOFPKIJDAMC, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF570", Offset = "0x6DCE970", VA = "0x186DCF570", Slot = "24")]
	public void COMBLHFAMMP(string KOFPKIJDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFFE0", Offset = "0x6DCF3E0", VA = "0x186DCFFE0", Slot = "9")]
	public bool NIEOJDJNIMN(string KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFCB0", Offset = "0x6DCF0B0", VA = "0x186DCFCB0", Slot = "25")]
	public Task LJEGCHNNFJI(CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DAFEC0", Offset = "0x1DAF2C0", VA = "0x181DAFEC0")]
	private T IKHPLCCBENN<T>(string KKIJPENOLBP, T OLNFJPNAOBM, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1DAECB0", Offset = "0x1DAE0B0", VA = "0x181DAECB0")]
	private void DADPJLGDIHI<T>(string KKIJPENOLBP, T KKIAKNLLHIO, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF890", Offset = "0x6DCEC90", VA = "0x186DCF890")]
	private Dictionary<string, string> JDJHGFMDELO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KJCDONPOEKP : HNFFDGDJOBC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private abstract class LLLKEHKONHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected static readonly HashSet<LLLKEHKONHC> ADMCJBMEGKB;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5210", Offset = "0x6DD4610", VA = "0x186DD5210")]
		public static void CFNJMKHPEFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void PEHJALIONDD();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		protected LLLKEHKONHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class LCFJDDJIJAC<T> : LLLKEHKONHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly LCFJDDJIJAC<T> HLFGGJBLCBK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ALIIKMJGANO<T> HBPDBFGKOPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEqualityComparer<T> ACPMINAJAGM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool NKFEOHPFFBA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x203B750", Offset = "0x203AB50", VA = "0x18203B750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x203BCF0", Offset = "0x203B0F0", VA = "0x18203BCF0")]
		private LCFJDDJIJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x203BA40", Offset = "0x203AE40", VA = "0x18203BA40")]
		public void FIMKNKKCEGK(ALIIKMJGANO<T> JAHBLLMDDJC, [Optional] IEqualityComparer<T> HFLKGIFCEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x203BBA0", Offset = "0x203AFA0", VA = "0x18203BBA0", Slot = "4")]
		public override void PEHJALIONDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FMFFDNHIFDO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly KJCDONPOEKP GCGGFFKCFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly object FIHPNHDFGBI;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6DD0200", Offset = "0x6DCF600", VA = "0x186DD0200")]
		public FMFFDNHIFDO(KJCDONPOEKP GCGGFFKCFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6DD01D0", Offset = "0x6DCF5D0", VA = "0x186DD01D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OELGKJPCHBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KJCDONPOEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public OELGKJPCHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5CC0", Offset = "0x6DD50C0", VA = "0x186DD5CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KNOCJHNPKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AIKJIPIMHLA backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public KJCDONPOEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KNOCJHNPKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4B20", Offset = "0x6DD3F20", VA = "0x186DD4B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LAOOAAKAKBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KJCDONPOEKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Task <local>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Task <cloud>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task <editor>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public LAOOAAKAKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4CE0", Offset = "0x6DD40E0", VA = "0x186DD4CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DMAMFPHJIDB : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private LJHFBCJIPCN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public KJCDONPOEKP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public DMAMFPHJIDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE930", Offset = "0x6DCDD30", VA = "0x186DCE930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE9C0", Offset = "0x6DCDDC0", VA = "0x186DCE9C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CIDEKEMPLEH DKGBHPJGFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CIDEKEMPLEH DFADACPOLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PPBMCNBKHII BFDFOJNJFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PKBGBEDEGAH BEIHHMBEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly LMDJEEFCDOJ CMJGJHBEFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HashSet<AIKJIPIMHLA> HKEIMMOALDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task GDOOIFPNNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private ODDHCGCOHBO MMOCDLCNOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly object OLKNPKAINME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly object NDGFENKLEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long LJBLJIJMIMM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool JIHOCOIMGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE00", Offset = "0x9BC200", VA = "0x1809BCE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private CancellationTokenSource CCANMKMHNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DD42F0", Offset = "0x6DD36F0", VA = "0x186DD42F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DD1F40", Offset = "0x6DD1340", VA = "0x186DD1F40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2950", Offset = "0x6DD1D50", VA = "0x186DD2950")]
	[GHLDKGGJCDP(FGNCLGKDFDK.None)]
	private static void GMGNMHCNENI(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DD48E0", Offset = "0x6DD3CE0", VA = "0x186DD48E0")]
	[Preserve]
	public KJCDONPOEKP([EPGFAMNCJKC("Disk")] CIDEKEMPLEH DKGBHPJGFDG, [EPGFAMNCJKC("Cloud")] CIDEKEMPLEH DFADACPOLAJ, [EPGFAMNCJKC(null)] PPBMCNBKHII BFDFOJNJFKN, [EPGFAMNCJKC(null)] PKBGBEDEGAH BEIHHMBEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DD21A0", Offset = "0x6DD15A0", VA = "0x186DD21A0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4150", Offset = "0x6DD3550", VA = "0x186DD4150")]
	private void OLJDJKFFHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD23B0", Offset = "0x6DD17B0", VA = "0x186DD23B0", Slot = "6")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1A10", Offset = "0x6DD0E10", VA = "0x186DD1A10", Slot = "7")]
	public Task CMIFOPMBFHK(long HHDCHJKCPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3FE0", Offset = "0x6DD33E0", VA = "0x186DD3FE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OELGKJPCHBF))]
	private Task OIAJNEDNFJM(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x9BC9E0", Offset = "0x9BBDE0", VA = "0x1809BC9E0")]
	private void GCOGAMBLLIB(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD28D0", Offset = "0x6DD1CD0", VA = "0x186DD28D0")]
	private void GINNKMHPCHJ(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2420", Offset = "0x6DD1820", VA = "0x186DD2420")]
	private string FFIDHGCCNID(string CNKLPKMACEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DD41F0", Offset = "0x6DD35F0", VA = "0x186DD41F0")]
	private void PDMMAMABCAO(LHEBPEBOALG CABENHAHAPC, string KOFPKIJDAMC, out CIDEKEMPLEH AMOLODEOFKG, out string MLKLGNOKNEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2D90", Offset = "0x6DD2190", VA = "0x186DD2D90")]
	private CIDEKEMPLEH IIENGHLILGO(LHEBPEBOALG CABENHAHAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1E90", Offset = "0x6DD1290", VA = "0x186DD1E90", Slot = "8")]
	public bool CPJDIKPJKNB(LHEBPEBOALG CABENHAHAPC = LHEBPEBOALG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3B90", Offset = "0x6DD2F90", VA = "0x186DD3B90", Slot = "9")]
	public bool MHGCBNGIKNG(string KKIJPENOLBP, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DD12B0", Offset = "0x6DD06B0", VA = "0x186DD12B0", Slot = "10")]
	public bool BMPDDDOCDPB(string KKIJPENOLBP, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2720", Offset = "0x6DD1B20", VA = "0x186DD2720", Slot = "11")]
	public string FHIHENKHNHK(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4650", Offset = "0x6DD3A50", VA = "0x186DD4650", Slot = "12")]
	public DHCGFHHJKLA PLADADEDOGP(string KKIJPENOLBP, string KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2EA0", Offset = "0x6DD22A0", VA = "0x186DD2EA0", Slot = "13")]
	public int JDDHENDLMJO(string KKIJPENOLBP, int OLNFJPNAOBM = 0, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3640", Offset = "0x6DD2A40", VA = "0x186DD3640", Slot = "14")]
	public DHCGFHHJKLA KMHGDHKONJL(string KKIJPENOLBP, int KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2C10", Offset = "0x6DD2010", VA = "0x186DD2C10", Slot = "15")]
	public bool HPHAJDJPBJI(string KKIJPENOLBP, bool OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0E20", Offset = "0x6DD0220", VA = "0x186DD0E20", Slot = "16")]
	public DHCGFHHJKLA ALBGMIGLECN(string KKIJPENOLBP, bool KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3CD0", Offset = "0x6DD30D0", VA = "0x186DD3CD0", Slot = "17")]
	public float MPJNFLLKEEN(string KKIJPENOLBP, float OLNFJPNAOBM = 0f, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2480", Offset = "0x6DD1880", VA = "0x186DD2480", Slot = "18")]
	public DHCGFHHJKLA FGLMEAOBANG(string KKIJPENOLBP, float KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0CA0", Offset = "0x6DD00A0", VA = "0x186DD0CA0", Slot = "19")]
	public DateTime AFBMBMNGBKJ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4390", Offset = "0x6DD3790", VA = "0x186DD4390", Slot = "20")]
	public DHCGFHHJKLA PJIPMOJPHDH(string KKIJPENOLBP, DateTime KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DD31B0", Offset = "0x6DD25B0", VA = "0x186DD31B0", Slot = "21")]
	public long JMAJPLDILBK(string KKIJPENOLBP, long OLNFJPNAOBM = 0L, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1C10", Offset = "0x6DD1010", VA = "0x186DD1C10", Slot = "22")]
	public DHCGFHHJKLA COEGCPLNGPD(string KKIJPENOLBP, long KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x24181C0", Offset = "0x24175C0", VA = "0x1824181C0", Slot = "23")]
	public T PNIGFPFABPM<T>(string KKIJPENOLBP, [Optional] T OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x24181C0", Offset = "0x24175C0", VA = "0x1824181C0", Slot = "24")]
	public DHCGFHHJKLA BPJGPGBPCNF<T>(string KKIJPENOLBP, T KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2E10", Offset = "0x6DD2210", VA = "0x186DD2E10", Slot = "25")]
	public bool IJHNGNONAML(string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4140", Offset = "0x6DD3540", VA = "0x186DD4140", Slot = "26")]
	public bool OIKANEPIJII(string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3E90", Offset = "0x6DD3290", VA = "0x186DD3E90", Slot = "27")]
	public string NPEBGMONNEH(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1280", Offset = "0x6DD0680", VA = "0x186DD1280", Slot = "28")]
	public DHCGFHHJKLA BBMACFLAFJK(string KKIJPENOLBP, string KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2BA0", Offset = "0x6DD1FA0", VA = "0x186DD2BA0", Slot = "29")]
	public int HMKKOFAANHA(string KKIJPENOLBP, int OLNFJPNAOBM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2D60", Offset = "0x6DD2160", VA = "0x186DD2D60", Slot = "30")]
	public DHCGFHHJKLA HPMPJCGKCMA(string KKIJPENOLBP, int KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3380", Offset = "0x6DD2780", VA = "0x186DD3380", Slot = "31")]
	public bool KFCOHOGABDK(string KKIJPENOLBP, bool OLNFJPNAOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD41C0", Offset = "0x6DD35C0", VA = "0x186DD41C0", Slot = "32")]
	public DHCGFHHJKLA PAJFEKGHKCI(string KKIJPENOLBP, bool KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3E20", Offset = "0x6DD3220", VA = "0x186DD3E20", Slot = "33")]
	public float NKHFEFKFJGA(string KKIJPENOLBP, float OLNFJPNAOBM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1250", Offset = "0x6DD0650", VA = "0x186DD1250", Slot = "34")]
	public DHCGFHHJKLA BAFJDFDLLPF(string KKIJPENOLBP, float KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3140", Offset = "0x6DD2540", VA = "0x186DD3140", Slot = "35")]
	public DateTime JLMJMHHEEMM(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0C70", Offset = "0x6DD0070", VA = "0x186DD0C70", Slot = "36")]
	public DHCGFHHJKLA AEGPFINEPIO(string KKIJPENOLBP, DateTime KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2130", Offset = "0x6DD1530", VA = "0x186DD2130", Slot = "37")]
	public long DBNBKGFKKOM(string KKIJPENOLBP, long OLNFJPNAOBM = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0DF0", Offset = "0x6DD01F0", VA = "0x186DD0DF0", Slot = "38")]
	public DHCGFHHJKLA AFNMGCODJJJ(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2870", Offset = "0x6DD1C70", VA = "0x186DD2870")]
	private bool FOFCBGCGENF(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1FE0", Offset = "0x6DD13E0", VA = "0x186DD1FE0")]
	private bool DBJJLBMKLBC(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DD14E0", Offset = "0x6DD08E0", VA = "0x186DD14E0")]
	private DHCGFHHJKLA BPGLPGLAKFB(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, string KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DD16A0", Offset = "0x6DD0AA0", VA = "0x186DD16A0")]
	private DHCGFHHJKLA BPLMEBBJEHK(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, int KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DD38D0", Offset = "0x6DD2CD0", VA = "0x186DD38D0")]
	private DHCGFHHJKLA KPPIPBLOJHM(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, bool KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1850", Offset = "0x6DD0C50", VA = "0x186DD1850")]
	private DHCGFHHJKLA CEBAPGDOBBA(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, float KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DD29C0", Offset = "0x6DD1DC0", VA = "0x186DD29C0")]
	private DHCGFHHJKLA GOMOFILHKFB(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, DateTime KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DD10A0", Offset = "0x6DD04A0", VA = "0x186DD10A0")]
	private DHCGFHHJKLA APOJDEGMIHB(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, long KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2418F50", Offset = "0x2418350", VA = "0x182418F50")]
	private T MCGPKBAHDOL<T>(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, T OLNFJPNAOBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2418360", Offset = "0x2417760", VA = "0x182418360")]
	private DHCGFHHJKLA KGLOACKGPOH<T>(AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, T KKIAKNLLHIO)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24195F0", Offset = "0x24189F0", VA = "0x1824195F0", Slot = "39")]
	public void OANBLCBBOMF<T>(ALIIKMJGANO<T> NNJDNGKINIP, [Optional] IEqualityComparer<T> HFLKGIFCEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2419530", Offset = "0x2418930", VA = "0x182419530", Slot = "40")]
	public void MFGNFHBGING<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3A80", Offset = "0x6DD2E80", VA = "0x186DD3A80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KNOCJHNPKEB))]
	private void LJEGCHNNFJI(AIKJIPIMHLA ADGADMJFEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2FF0", Offset = "0x6DD23F0", VA = "0x186DD2FF0", Slot = "43")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LAOOAAKAKBA))]
	public Task JDOIKJINHJI([Optional] CancellationToken GAOLOMEJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DD21F0", Offset = "0x6DD15F0", VA = "0x186DD21F0")]
	private void ENDDLCDALLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3F00", Offset = "0x6DD3300", VA = "0x186DD3F00", Slot = "41")]
	public IDisposable OBPFFKFEKKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DD38C0", Offset = "0x6DD2CC0", VA = "0x186DD38C0", Slot = "42")]
	public void KMPDBCDPDFI(float FBDCHBAJFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DD33F0", Offset = "0x6DD27F0", VA = "0x186DD33F0")]
	private void KIBMKNIPIPE(float PDHDCAEDCPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DD3300", Offset = "0x6DD2700", VA = "0x186DD3300")]
	[IteratorStateMachine(typeof(DMAMFPHJIDB))]
	private IEnumerator<LJHFBCJIPCN> KCJDJHLPHIA(float FBDCHBAJFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2E70", Offset = "0x6DD2270", VA = "0x186DD2E70")]
	[CompilerGenerated]
	private void IMPOLGPMNJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class NOPBJDAJBEJ<TParent> where TParent : AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly HashSet<NOPBJDAJBEJ<TParent>> NJMBCGEAFML;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5180", Offset = "0x2AA4580", VA = "0x182AA5180")]
	protected NOPBJDAJBEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void PEHJALIONDD();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void MMEEECIJALL(string KOFPKIJDAMC);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4DA0", Offset = "0x2AA41A0", VA = "0x182AA4DA0")]
	public static void NOLCBMHJMJM(string KOFPKIJDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2AA4AC0", Offset = "0x2AA3EC0", VA = "0x182AA4AC0")]
	public static void CFNJMKHPEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NEBNPOFLBFL<TParent, TValue> : NOPBJDAJBEJ<TParent> where TParent : AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly NEBNPOFLBFL<TParent, TValue> DEEICBABDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<string, TValue> LANOBMELHPI;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1EF9400", Offset = "0x1EF8800", VA = "0x181EF9400")]
	public bool HPMOKKNEDOE(string JAAPKECBADL, out TValue AOKKFNFFBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x27C8CB0", Offset = "0x27C80B0", VA = "0x1827C8CB0")]
	public void NBBDJCJLBPB(string JAAPKECBADL, TValue KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xEF1D70", Offset = "0xEF1170", VA = "0x180EF1D70", Slot = "4")]
	protected override void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x16C3C60", Offset = "0x16C3060", VA = "0x1816C3C60", Slot = "5")]
	protected override void MMEEECIJALL(string JAAPKECBADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20BE330", Offset = "0x20BD730", VA = "0x1820BE330")]
	public NEBNPOFLBFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NEACLBDGICP : CIDEKEMPLEH, AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KFIHKIJDENE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NEACLBDGICP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KFIHKIJDENE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6DD0910", Offset = "0x6DCFD10", VA = "0x186DD0910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LPBFHMCLDKE : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LJHFBCJIPCN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NEACLBDGICP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public LPBFHMCLDKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DD53C0", Offset = "0x6DD47C0", VA = "0x186DD53C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DD5430", Offset = "0x6DD4830", VA = "0x186DD5430", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool GHNEFIGOOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool IAGLGOLDAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private PKBGBEDEGAH BEIHHMBEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ODDHCGCOHBO AOIBJGJAFPC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5BE0", Offset = "0x6DD4FE0", VA = "0x186DD5BE0")]
	[Preserve]
	public NEACLBDGICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6DD55C0", Offset = "0x6DD49C0", VA = "0x186DD55C0", Slot = "6")]
	public Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A914F0", Offset = "0x3A908F0", VA = "0x183A914F0")]
	private static int IIPBCGLOAIF(bool KKIAKNLLHIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5BB0", Offset = "0x6DD4FB0", VA = "0x186DD5BB0", Slot = "9")]
	public bool NIEOJDJNIMN(string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7360", Offset = "0x4FF6760", VA = "0x184FF7360", Slot = "10")]
	public int IGOPLLJIMKI(string KKIJPENOLBP, int OLNFJPNAOBM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7370", Offset = "0x4FF6770", VA = "0x184FF7370", Slot = "11")]
	public void OJCHJHFBOPI(string KKIJPENOLBP, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD58C0", Offset = "0x6DD4CC0", VA = "0x186DD58C0", Slot = "12")]
	public bool IDLOLHPHMCM(string KKIJPENOLBP, bool OLNFJPNAOBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5680", Offset = "0x6DD4A80", VA = "0x186DD5680", Slot = "13")]
	public void BNFEBFAMPLO(string KKIJPENOLBP, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD58E0", Offset = "0x6DD4CE0", VA = "0x186DD58E0", Slot = "14")]
	public float INKEHDBAJKG(string KKIJPENOLBP, float OLNFJPNAOBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5BA0", Offset = "0x6DD4FA0", VA = "0x186DD5BA0", Slot = "15")]
	public void MINIBEBGMIB(string KKIJPENOLBP, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5BC0", Offset = "0x6DD4FC0", VA = "0x186DD5BC0", Slot = "16")]
	public string ONOOJIGOPOK(string KKIJPENOLBP, string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD59C0", Offset = "0x6DD4DC0", VA = "0x186DD59C0", Slot = "17")]
	public void KMHPHPGIDFJ(string KKIJPENOLBP, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6DD59E0", Offset = "0x6DD4DE0", VA = "0x186DD59E0", Slot = "18")]
	public DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5610", Offset = "0x6DD4A10", VA = "0x186DD5610", Slot = "19")]
	public void AKJAFOECPJK(string KKIJPENOLBP, DateTime CCDOGFAPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5690", Offset = "0x6DD4A90", VA = "0x186DD5690", Slot = "20")]
	public long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5770", Offset = "0x6DD4B70", VA = "0x186DD5770", Slot = "21")]
	public void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "22")]
	public T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "23")]
	public void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE180", Offset = "0x1FED580", VA = "0x181FEE180")]
	private T OEBAPPLDBIN<T>(string KKIJPENOLBP, T OLNFJPNAOBM, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1FED990", Offset = "0x1FECD90", VA = "0x181FED990")]
	private void IBKDAKIIEGJ<T>(string KKIJPENOLBP, T KKIAKNLLHIO, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5700", Offset = "0x6DD4B00", VA = "0x186DD5700", Slot = "24")]
	public void COMBLHFAMMP(string KKIJPENOLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5A50", Offset = "0x6DD4E50", VA = "0x186DD5A50", Slot = "25")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KFIHKIJDENE))]
	public Task LJEGCHNNFJI(CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5850", Offset = "0x6DD4C50", VA = "0x186DD5850")]
	[IteratorStateMachine(typeof(LPBFHMCLDKE))]
	private IEnumerator<LJHFBCJIPCN> GNBGJKJKGPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6DD58F0", Offset = "0x6DD4CF0", VA = "0x186DD58F0")]
	private void JDOIKJINHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5950", Offset = "0x6DD4D50", VA = "0x186DD5950")]
	private void KGBEPFKGJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DD57E0", Offset = "0x6DD4BE0", VA = "0x186DD57E0")]
	private void DJGBDEHMBEE(bool KBGEKHKOJMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class MOHAIDMKFKA
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5470", Offset = "0x6DD4870", VA = "0x186DD5470")]
	[GHLDKGGJCDP(FGNCLGKDFDK.None)]
	private static void FGOGAKCFKDL(EPBOEGFMAOO OHJGEOICJDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DCDPKFPHNJK : CIDEKEMPLEH, AIKJIPIMHLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Dictionary<string, byte> KALCDLFGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Dictionary<string, string> KGHHDBPCLOM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Dictionary<string, string> AEKCEBHEBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE870", Offset = "0x6DCDC70", VA = "0x186DCE870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE8B0", Offset = "0x6DCDCB0", VA = "0x186DCE8B0")]
	[Preserve]
	public DCDPKFPHNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD500", Offset = "0x6DCC900", VA = "0x186DCD500")]
	private DirectoryInfo IDJGBFFENMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCF30", Offset = "0x6DCC330", VA = "0x186DCCF30", Slot = "6")]
	public Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD730", Offset = "0x6DCCB30", VA = "0x186DCD730", Slot = "14")]
	public float INKEHDBAJKG(string KOFPKIJDAMC, float OLNFJPNAOBM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCFF0", Offset = "0x6DCC3F0", VA = "0x186DCCFF0", Slot = "13")]
	public void BNFEBFAMPLO(string KOFPKIJDAMC, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD5D0", Offset = "0x6DCC9D0", VA = "0x186DCD5D0", Slot = "12")]
	public bool IDLOLHPHMCM(string KOFPKIJDAMC, bool OLNFJPNAOBM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD6C0", Offset = "0x6DCCAC0", VA = "0x186DCD6C0", Slot = "10")]
	public int IGOPLLJIMKI(string KOFPKIJDAMC, int OLNFJPNAOBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDFB0", Offset = "0x6DCD3B0", VA = "0x186DCDFB0", Slot = "18")]
	public DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCF80", Offset = "0x6DCC380", VA = "0x186DCCF80", Slot = "19")]
	public void AKJAFOECPJK(string KOFPKIJDAMC, DateTime KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE650", Offset = "0x6DCDA50", VA = "0x186DCE650", Slot = "15")]
	public void MINIBEBGMIB(string KOFPKIJDAMC, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE750", Offset = "0x6DCDB50", VA = "0x186DCE750", Slot = "11")]
	public void OJCHJHFBOPI(string KOFPKIJDAMC, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD160", Offset = "0x6DCC560", VA = "0x186DCD160", Slot = "20")]
	public long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD2B0", Offset = "0x6DCC6B0", VA = "0x186DCD2B0", Slot = "21")]
	public void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "22")]
	public T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x19642F0", Offset = "0x19636F0", VA = "0x1819642F0", Slot = "23")]
	public void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE7C0", Offset = "0x6DCDBC0", VA = "0x186DCE7C0", Slot = "16")]
	public string ONOOJIGOPOK(string KOFPKIJDAMC, string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDF40", Offset = "0x6DCD340", VA = "0x186DCDF40", Slot = "17")]
	public void KMHPHPGIDFJ(string KOFPKIJDAMC, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD1D0", Offset = "0x6DCC5D0", VA = "0x186DCD1D0", Slot = "24")]
	public void COMBLHFAMMP(string KOFPKIJDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE6C0", Offset = "0x6DCDAC0", VA = "0x186DCE6C0", Slot = "9")]
	public bool NIEOJDJNIMN(string KOFPKIJDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE020", Offset = "0x6DCD420", VA = "0x186DCE020", Slot = "25")]
	public Task LJEGCHNNFJI(CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE330", Offset = "0x6DCD730", VA = "0x186DCE330")]
	private void MAFHCMDAHMB(DirectoryInfo MJCHNIJABKN, string OBMMKKOGJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD320", Offset = "0x6DCC720", VA = "0x186DCD320")]
	private static string FHMCBOMOHOL(string KOFPKIJDAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD060", Offset = "0x6DCC460", VA = "0x186DCD060")]
	private static string CHLKGHBOOCD(byte[] NCKLDJBDGMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x268DA90", Offset = "0x268CE90", VA = "0x18268DA90")]
	private T IKHPLCCBENN<T>(string KKIJPENOLBP, T OLNFJPNAOBM, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x268C520", Offset = "0x268B920", VA = "0x18268C520")]
	private void DADPJLGDIHI<T>(string KKIJPENOLBP, T KKIAKNLLHIO, [Optional] ALIIKMJGANO<T> JAHBLLMDDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD7A0", Offset = "0x6DCCBA0", VA = "0x186DCD7A0")]
	private Dictionary<string, string> JDJHGFMDELO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface HNFFDGDJOBC
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action AGIOFKOGCBL;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOLKEKLLNGL();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task CMIFOPMBFHK(long HHDCHJKCPDB);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CPJDIKPJKNB(LHEBPEBOALG CABENHAHAPC = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MHGCBNGIKNG(string KKIJPENOLBP, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BMPDDDOCDPB(string KKIJPENOLBP, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string FHIHENKHNHK(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DHCGFHHJKLA PLADADEDOGP(string KKIJPENOLBP, string KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int JDDHENDLMJO(string KKIJPENOLBP, int OLNFJPNAOBM = 0, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DHCGFHHJKLA KMHGDHKONJL(string KKIJPENOLBP, int KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HPHAJDJPBJI(string KKIJPENOLBP, bool OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DHCGFHHJKLA ALBGMIGLECN(string KKIJPENOLBP, bool KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float MPJNFLLKEEN(string KKIJPENOLBP, float OLNFJPNAOBM = 0f, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DHCGFHHJKLA FGLMEAOBANG(string KKIJPENOLBP, float KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime AFBMBMNGBKJ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	DHCGFHHJKLA PJIPMOJPHDH(string KKIJPENOLBP, DateTime KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long JMAJPLDILBK(string KKIJPENOLBP, long OLNFJPNAOBM = 0L, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DHCGFHHJKLA COEGCPLNGPD(string KKIJPENOLBP, long KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T PNIGFPFABPM<T>(string KKIJPENOLBP, [Optional] T OLNFJPNAOBM, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	DHCGFHHJKLA BPJGPGBPCNF<T>(string KKIJPENOLBP, T KKIAKNLLHIO, LHEBPEBOALG JPOHNOGHLJA = LHEBPEBOALG.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool IJHNGNONAML(string KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool OIKANEPIJII(string KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string NPEBGMONNEH(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	DHCGFHHJKLA BBMACFLAFJK(string KKIJPENOLBP, string KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int HMKKOFAANHA(string KKIJPENOLBP, int OLNFJPNAOBM = 0);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	DHCGFHHJKLA HPMPJCGKCMA(string KKIJPENOLBP, int KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KFCOHOGABDK(string KKIJPENOLBP, bool OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	DHCGFHHJKLA PAJFEKGHKCI(string KKIJPENOLBP, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float NKHFEFKFJGA(string KKIJPENOLBP, float OLNFJPNAOBM = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	DHCGFHHJKLA BAFJDFDLLPF(string KKIJPENOLBP, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime JLMJMHHEEMM(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	DHCGFHHJKLA AEGPFINEPIO(string KKIJPENOLBP, DateTime KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long DBNBKGFKKOM(string KKIJPENOLBP, long OLNFJPNAOBM = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	DHCGFHHJKLA AFNMGCODJJJ(string KKIJPENOLBP, long KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OANBLCBBOMF<T>(ALIIKMJGANO<T> NNJDNGKINIP, [Optional] IEqualityComparer<T> HFLKGIFCEEE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void MFGNFHBGING<T>();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable OBPFFKFEKKB();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KMPDBCDPDFI(float FBDCHBAJFIH);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task JDOIKJINHJI([Optional] CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum DHCGFHHJKLA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOLKEKLLNGL();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NIEOJDJNIMN(string KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IGOPLLJIMKI(string KKIJPENOLBP, int OLNFJPNAOBM = 0);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJCHJHFBOPI(string KKIJPENOLBP, int KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IDLOLHPHMCM(string KKIJPENOLBP, bool OLNFJPNAOBM = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNFEBFAMPLO(string KKIJPENOLBP, bool KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float INKEHDBAJKG(string KKIJPENOLBP, float OLNFJPNAOBM = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MINIBEBGMIB(string KKIJPENOLBP, float KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string ONOOJIGOPOK(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KMHPHPGIDFJ(string KKIJPENOLBP, string KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime CCDOGFAPCNE);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AKJAFOECPJK(string KKIJPENOLBP, DateTime CCDOGFAPCNE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void COMBLHFAMMP(string KKIJPENOLBP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task LJEGCHNNFJI([Optional] CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CIDEKEMPLEH : AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action AGIOFKOGCBL;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface PPBMCNBKHII : AIKJIPIMHLA
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KMGLPHBHFKE : JEDADCMMBNA
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0890", Offset = "0x6DCFC90", VA = "0x186DD0890")]
	[Preserve]
	public KMGLPHBHFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OFIPKKDBKMH : CIDEKEMPLEH, AIKJIPIMHLA
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class BCLIKIJGFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public OFIPKKDBKMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BCLIKIJGFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCDD0", Offset = "0x6DCC1D0", VA = "0x186DCCDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class ONJBOOJLLDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public long playerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public OFIPKKDBKMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public ONJBOOJLLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6DD71F0", Offset = "0x6DD65F0", VA = "0x186DD71F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CIDEKEMPLEH NLKNFHHGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly DCDPKFPHNJK GLGKDCJGECK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6180", Offset = "0x6DD5580", VA = "0x186DD6180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6DD70B0", Offset = "0x6DD64B0", VA = "0x186DD70B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6540", Offset = "0x6DD5940", VA = "0x186DD6540", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7110", Offset = "0x6DD6510", VA = "0x186DD7110")]
	[Preserve]
	public OFIPKKDBKMH(CIDEKEMPLEH NLKNFHHGGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD65B0", Offset = "0x6DD59B0", VA = "0x186DD65B0", Slot = "8")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6E20", Offset = "0x6DD6220", VA = "0x186DD6E20", Slot = "9")]
	public bool NIEOJDJNIMN(string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD67D0", Offset = "0x6DD5BD0", VA = "0x186DD67D0", Slot = "10")]
	public int IGOPLLJIMKI(string KKIJPENOLBP, int OLNFJPNAOBM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6EB0", Offset = "0x6DD62B0", VA = "0x186DD6EB0", Slot = "11")]
	public void OJCHJHFBOPI(string KKIJPENOLBP, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6610", Offset = "0x6DD5A10", VA = "0x186DD6610", Slot = "12")]
	public bool IDLOLHPHMCM(string KKIJPENOLBP, bool OLNFJPNAOBM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD61E0", Offset = "0x6DD55E0", VA = "0x186DD61E0", Slot = "13")]
	public void BNFEBFAMPLO(string KKIJPENOLBP, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6930", Offset = "0x6DD5D30", VA = "0x186DD6930", Slot = "14")]
	public float INKEHDBAJKG(string KKIJPENOLBP, float OLNFJPNAOBM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6DB0", Offset = "0x6DD61B0", VA = "0x186DD6DB0", Slot = "15")]
	public void MINIBEBGMIB(string KKIJPENOLBP, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6F20", Offset = "0x6DD6320", VA = "0x186DD6F20", Slot = "16")]
	public string ONOOJIGOPOK(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6A90", Offset = "0x6DD5E90", VA = "0x186DD6A90", Slot = "17")]
	public void KMHPHPGIDFJ(string KKIJPENOLBP, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6B00", Offset = "0x6DD5F00", VA = "0x186DD6B00", Slot = "18")]
	public DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6110", Offset = "0x6DD5510", VA = "0x186DD6110", Slot = "19")]
	public void AKJAFOECPJK(string KKIJPENOLBP, DateTime CCDOGFAPCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6250", Offset = "0x6DD5650", VA = "0x186DD6250", Slot = "20")]
	public long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6DD64D0", Offset = "0x6DD58D0", VA = "0x186DD64D0", Slot = "21")]
	public void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x12C4DA0", Offset = "0x12C41A0", VA = "0x1812C4DA0", Slot = "22")]
	public T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x12C5420", Offset = "0x12C4820", VA = "0x1812C5420", Slot = "23")]
	public void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD63B0", Offset = "0x6DD57B0", VA = "0x186DD63B0", Slot = "24")]
	public void COMBLHFAMMP(string KKIJPENOLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6C60", Offset = "0x6DD6060", VA = "0x186DD6C60", Slot = "25")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BCLIKIJGFEE))]
	public Task LJEGCHNNFJI([Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD5FB0", Offset = "0x6DD53B0", VA = "0x186DD5FB0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ONJBOOJLLDB))]
	public Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JEDADCMMBNA : CIDEKEMPLEH, AIKJIPIMHLA, PPBMCNBKHII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Dictionary<string, object> ONEJKKFHMJL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MADHFPDLGFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action AGIOFKOGCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
	public void EOLKEKLLNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6DD02B0", Offset = "0x6DCF6B0", VA = "0x186DD02B0", Slot = "6")]
	public Task AGCKGEKFAOE(long HHDCHJKCPDB, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0770", Offset = "0x6DCFB70", VA = "0x186DD0770", Slot = "9")]
	public bool NIEOJDJNIMN(string KKIJPENOLBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0540", Offset = "0x6DCF940", VA = "0x186DD0540", Slot = "10")]
	public int IGOPLLJIMKI(string KKIJPENOLBP, int OLNFJPNAOBM = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD07D0", Offset = "0x6DCFBD0", VA = "0x186DD07D0", Slot = "11")]
	public void OJCHJHFBOPI(string KKIJPENOLBP, int KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD04E0", Offset = "0x6DCF8E0", VA = "0x186DD04E0", Slot = "12")]
	public bool IDLOLHPHMCM(string KKIJPENOLBP, bool OLNFJPNAOBM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0360", Offset = "0x6DCF760", VA = "0x186DD0360", Slot = "13")]
	public void BNFEBFAMPLO(string KKIJPENOLBP, bool KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD05A0", Offset = "0x6DCF9A0", VA = "0x186DD05A0", Slot = "14")]
	public float INKEHDBAJKG(string KKIJPENOLBP, float OLNFJPNAOBM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0710", Offset = "0x6DCFB10", VA = "0x186DD0710", Slot = "15")]
	public void MINIBEBGMIB(string KKIJPENOLBP, float KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0830", Offset = "0x6DCFC30", VA = "0x186DD0830", Slot = "16")]
	public string ONOOJIGOPOK(string KKIJPENOLBP, [Optional] string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0600", Offset = "0x6DCFA00", VA = "0x186DD0600", Slot = "17")]
	public void KMHPHPGIDFJ(string KKIJPENOLBP, string KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0660", Offset = "0x6DCFA60", VA = "0x186DD0660", Slot = "18")]
	public DateTime LIFDAGJININ(string KKIJPENOLBP, [Optional] DateTime OLNFJPNAOBM)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0300", Offset = "0x6DCF700", VA = "0x186DD0300", Slot = "19")]
	public void AKJAFOECPJK(string KKIJPENOLBP, DateTime KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6DD03C0", Offset = "0x6DCF7C0", VA = "0x186DD03C0", Slot = "20")]
	public long CKFJLKPJINC(string KKIJPENOLBP, long OLNFJPNAOBM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0480", Offset = "0x6DCF880", VA = "0x186DD0480", Slot = "21")]
	public void DADMLJGEOLN(string KKIJPENOLBP, long KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xBD60C0", Offset = "0xBD54C0", VA = "0x180BD60C0", Slot = "22")]
	public T MPHBOGEAIKL<T>(string KKIJPENOLBP, T OLNFJPNAOBM, ALIIKMJGANO<T> NNJDNGKINIP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xBD60C0", Offset = "0xBD54C0", VA = "0x180BD60C0", Slot = "23")]
	public void NDEKLBJNFOO<T>(string KKIJPENOLBP, T KKIAKNLLHIO, ALIIKMJGANO<T> NNJDNGKINIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xBD5890", Offset = "0xBD4C90", VA = "0x180BD5890")]
	public T IKHPLCCBENN<T>(string KKIJPENOLBP, T OLNFJPNAOBM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xBD53A0", Offset = "0xBD47A0", VA = "0x180BD53A0")]
	public void DADPJLGDIHI<T>(string KKIJPENOLBP, T KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0420", Offset = "0x6DCF820", VA = "0x186DD0420", Slot = "24")]
	public void COMBLHFAMMP(string KKIJPENOLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD06C0", Offset = "0x6DCFAC0", VA = "0x186DD06C0", Slot = "25")]
	public Task LJEGCHNNFJI(CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0890", Offset = "0x6DCFC90", VA = "0x186DD0890")]
	public JEDADCMMBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LHEBPEBOALG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class FBPMDHLHPJP
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEDB0", Offset = "0x6DCE1B0", VA = "0x186DCEDB0")]
	private static void EMCFCADKGCI(AIKJIPIMHLA AMOLODEOFKG, Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCECB0", Offset = "0x6DCE0B0", VA = "0x186DCECB0")]
	public static bool EFGIGPEAFDF(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEB50", Offset = "0x6DCDF50", VA = "0x186DCEB50")]
	public static DHCGFHHJKLA CGJKCHMKCEF(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, string KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF120", Offset = "0x6DCE520", VA = "0x186DCF120")]
	public static DHCGFHHJKLA OBELJIONMJG(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, int KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEE40", Offset = "0x6DCE240", VA = "0x186DCEE40")]
	public static DHCGFHHJKLA EPPIOAPBKKP(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, bool KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF270", Offset = "0x6DCE670", VA = "0x186DCF270")]
	public static DHCGFHHJKLA OLHBHIPCEGM(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, float KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEF90", Offset = "0x6DCE390", VA = "0x186DCEF90")]
	public static DHCGFHHJKLA JDJIEFIDOGO(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, DateTime KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6DCEA00", Offset = "0x6DCDE00", VA = "0x186DCEA00")]
	public static DHCGFHHJKLA CEILAJBCDKI(this AIKJIPIMHLA AMOLODEOFKG, string KKIJPENOLBP, long KKIAKNLLHIO, [Optional] Action<AIKJIPIMHLA> PEBOAHJMKFP)
	{
		return default(DHCGFHHJKLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PLKLOEFMICB : MLAAIBBELGP<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static PLKLOEFMICB HLFGGJBLCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7490", Offset = "0x6DD6890", VA = "0x186DD7490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7810", Offset = "0x6DD6C10", VA = "0x186DD7810", Slot = "9")]
	public override string IBKPGJDIIJI(bool IGBONFEPFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6DD74F0", Offset = "0x6DD68F0", VA = "0x186DD74F0", Slot = "10")]
	protected override bool HNNBGANABOH(string IGBONFEPFAO, out bool KKIAKNLLHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7980", Offset = "0x6DD6D80", VA = "0x186DD7980")]
	public PLKLOEFMICB()
	{
	}
}
namespace Cpp2IlInjected;

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
