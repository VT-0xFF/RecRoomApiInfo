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
public class KLNDAKHANJI : GNELEDNOFJI, DANHLLNBANE
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
	private Dictionary<string, string> EKMHMBEBEML;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private string JGKIIKAHCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EA60", Offset = "0x6E1D060", VA = "0x186E1EA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private Dictionary<string, string> GPAJFMOBPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EEC0", Offset = "0x6E1D4C0", VA = "0x186E1EEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	[Preserve]
	public KLNDAKHANJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EE70", Offset = "0x6E1D470", VA = "0x186E1EE70", Slot = "6")]
	public Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EFA0", Offset = "0x6E1D5A0", VA = "0x186E1EFA0", Slot = "14")]
	public float HAAGNNEMFDL(string BOMEFJIOGGM, float INIEFLCMFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F210", Offset = "0x6E1D810", VA = "0x186E1F210", Slot = "13")]
	public void LKHNCACBGLO(string BOMEFJIOGGM, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F690", Offset = "0x6E1DC90", VA = "0x186E1F690", Slot = "12")]
	public bool OBDBCLKJNOJ(string BOMEFJIOGGM, bool INIEFLCMFEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F0F0", Offset = "0x6E1D6F0", VA = "0x186E1F0F0", Slot = "10")]
	public int JJJIKDHDLIN(string BOMEFJIOGGM, int INIEFLCMFEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F7F0", Offset = "0x6E1DDF0", VA = "0x186E1F7F0", Slot = "18")]
	public DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F590", Offset = "0x6E1DB90", VA = "0x186E1F590", Slot = "19")]
	public void NKHONKMAPKF(string BOMEFJIOGGM, DateTime MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EAD0", Offset = "0x6E1D0D0", VA = "0x186E1EAD0", Slot = "15")]
	public void ALCFGKMCOPK(string BOMEFJIOGGM, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F010", Offset = "0x6E1D610", VA = "0x186E1F010", Slot = "11")]
	public void HGGJDPFGGPE(string BOMEFJIOGGM, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F080", Offset = "0x6E1D680", VA = "0x186E1F080", Slot = "20")]
	public long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F780", Offset = "0x6E1DD80", VA = "0x186E1F780", Slot = "21")]
	public void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "22")]
	public T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "23")]
	public void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F160", Offset = "0x6E1D760", VA = "0x186E1F160", Slot = "16")]
	public string KFNCGHMLMAI(string BOMEFJIOGGM, string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EF00", Offset = "0x6E1D500", VA = "0x186E1EF00", Slot = "17")]
	public void GNFDJCHKCBE(string BOMEFJIOGGM, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ED90", Offset = "0x6E1D390", VA = "0x186E1ED90", Slot = "24")]
	public void CCGHLBADJDF(string BOMEFJIOGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F600", Offset = "0x6E1DC00", VA = "0x186E1F600", Slot = "9")]
	public bool NNNMNHGJFEH(string BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EB40", Offset = "0x6E1D140", VA = "0x186E1EB40", Slot = "25")]
	public Task AOLHMJCEMBO(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xF3B180", Offset = "0xF39780", VA = "0x180F3B180")]
	private T MBNHJLNEIKL<T>(string EFINPLKEDMK, T INIEFLCMFEE, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0xF39E40", Offset = "0xF38440", VA = "0x180F39E40")]
	private void FGMAFKALEHD<T>(string EFINPLKEDMK, T MOLEJFDINLH, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F280", Offset = "0x6E1D880", VA = "0x186E1F280")]
	private Dictionary<string, string> MLEOIIFADOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OJGFFDFKFJO : OEDCEGNGFJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private abstract class GPDDAIMHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected static readonly HashSet<GPDDAIMHPEI> FIMBGMMJNAI;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E250", Offset = "0x6E1C850", VA = "0x186E1E250")]
		public static void BAAOMLFNNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FBJOPIHCMHF();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		protected GPDDAIMHPEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class INPBBLCGGOE<T> : GPDDAIMHPEI
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly INPBBLCGGOE<T> HAMPJMKDJOL;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ENKHNBEGBEI<T> HIBEHCFJCOD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IEqualityComparer<T> DCDKOBFOELN
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool BNJAGEMKDHG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1E73380", Offset = "0x1E71980", VA = "0x181E73380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3E26600", Offset = "0x3E24C00", VA = "0x183E26600")]
		private INPBBLCGGOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3E260F0", Offset = "0x3E246F0", VA = "0x183E260F0")]
		public void MBACIJOLGCB(ENKHNBEGBEI<T> GFOAEAMDGAL, [Optional] IEqualityComparer<T> OHDCMCANAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3E26090", Offset = "0x3E24690", VA = "0x183E26090", Slot = "4")]
		public override void FBJOPIHCMHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class FGMNHNOHOJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly OJGFFDFKFJO EOCNJKDCCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly object IIBNEHFNKFH;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D160", Offset = "0x6E1B760", VA = "0x186E1D160")]
		public FGMNHNOHOJN(OJGFFDFKFJO EOCNJKDCCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D130", Offset = "0x6E1B730", VA = "0x186E1D130", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JPOIECKIADI : IAsyncStateMachine
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
		public OJGFFDFKFJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public JPOIECKIADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E770", Offset = "0x6E1CD70", VA = "0x186E1E770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GMFNLBNOMBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DANHLLNBANE backingStoreToSave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OJGFFDFKFJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GMFNLBNOMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E090", Offset = "0x6E1C690", VA = "0x186E1E090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BHGJMENNOHH : IAsyncStateMachine
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
		public OJGFFDFKFJO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public BHGJMENNOHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6E19930", Offset = "0x6E17F30", VA = "0x186E19930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class HNPEFOLGMBK : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public OJGFFDFKFJO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public HNPEFOLGMBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E400", Offset = "0x6E1CA00", VA = "0x186E1E400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E490", Offset = "0x6E1CA90", VA = "0x186E1E490", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GNELEDNOFJI DJPALJPAPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GNELEDNOFJI HAGNGLAAGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BECEAGKCLKN KKCHIPJGBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CDNNNIJHPJN EBLGJABNHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly DMMBJKBEDJE OFFGBGKHCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HashSet<DANHLLNBANE> OPOBNOGCFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private Task DADGDGIHBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BDPNFFCBKDC ADAGACKCGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly object FNADHLPJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly object IEKGDICPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long AKGLEIIJKJL;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool CEFBDJOHBHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x924C00", Offset = "0x923200", VA = "0x180924C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private CancellationTokenSource PFGDBGLCCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E21550", Offset = "0x6E1FB50", VA = "0x186E21550", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E21180", Offset = "0x6E1F780", VA = "0x186E21180", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E215F0", Offset = "0x6E1FBF0", VA = "0x186E215F0")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void GBPEJJMEKGC(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E23C50", Offset = "0x6E22250", VA = "0x186E23C50")]
	[Preserve]
	public OJGFFDFKFJO([BBBJPGKHPHG("Disk")] GNELEDNOFJI DJPALJPAPJO, [BBBJPGKHPHG("Cloud")] GNELEDNOFJI HAGNGLAAGOM, [BBBJPGKHPHG(null)] BECEAGKCLKN KKCHIPJGBCI, [BBBJPGKHPHG(null)] CDNNNIJHPJN EBLGJABNHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E212D0", Offset = "0x6E1F8D0", VA = "0x186E212D0", Slot = "44")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E22450", Offset = "0x6E20A50", VA = "0x186E22450")]
	private void IDENIMDBPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E227D0", Offset = "0x6E20DD0", VA = "0x186E227D0", Slot = "6")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E206D0", Offset = "0x6E1ECD0", VA = "0x186E206D0", Slot = "7")]
	public Task BDFELCLANEC(long DMCPHLADIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E208D0", Offset = "0x6E1EED0", VA = "0x186E208D0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JPOIECKIADI))]
	private Task BEAJNOGDLKL(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x924600", Offset = "0x922C00", VA = "0x180924600")]
	private void PDECOKCCDOH(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E22990", Offset = "0x6E20F90", VA = "0x186E22990")]
	private void JEMJBNOPEBC(object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E22FF0", Offset = "0x6E215F0", VA = "0x186E22FF0")]
	private string MKOEMCCKODI(string OMDHNEHEHFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E218F0", Offset = "0x6E1FEF0", VA = "0x186E218F0")]
	private void GJOBPEFCBAI(KONOJAHEIKM ALIADLJIBBE, string BOMEFJIOGGM, out GNELEDNOFJI AEAJFPAFAJK, out string LHGIJGNFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E224C0", Offset = "0x6E20AC0", VA = "0x186E224C0")]
	private GNELEDNOFJI IFBNBPEDELB(KONOJAHEIKM ALIADLJIBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E21220", Offset = "0x6E1F820", VA = "0x186E21220", Slot = "8")]
	public bool DMMCIOACNHA(KONOJAHEIKM ALIADLJIBBE = KONOJAHEIKM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E23860", Offset = "0x6E21E60", VA = "0x186E23860", Slot = "9")]
	public bool OCDNJLMNHHE(string EFINPLKEDMK, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E216C0", Offset = "0x6E1FCC0", VA = "0x186E216C0", Slot = "10")]
	public bool GFBJMPNGBBL(string EFINPLKEDMK, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E23AF0", Offset = "0x6E220F0", VA = "0x186E23AF0", Slot = "11")]
	public string OINJPPBJMPG(string EFINPLKEDMK, [Optional] string INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E219F0", Offset = "0x6E1FFF0", VA = "0x186E219F0", Slot = "12")]
	public NCFIDMFBOLI GKBKBHCNDDN(string EFINPLKEDMK, string MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E22E20", Offset = "0x6E21420", VA = "0x186E22E20", Slot = "13")]
	public int MIMDPLFIFOM(string EFINPLKEDMK, int INIEFLCMFEE = 0, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E20ED0", Offset = "0x6E1F4D0", VA = "0x186E20ED0", Slot = "14")]
	public NCFIDMFBOLI CGOOHOENGCE(string EFINPLKEDMK, int MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E20130", Offset = "0x6E1E730", VA = "0x186E20130", Slot = "15")]
	public bool ACAJLIJMFLD(string EFINPLKEDMK, bool INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E231C0", Offset = "0x6E217C0", VA = "0x186E231C0", Slot = "16")]
	public NCFIDMFBOLI NKGFINKBLCH(string EFINPLKEDMK, bool MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E22AB0", Offset = "0x6E210B0", VA = "0x186E22AB0", Slot = "17")]
	public float LCLFNKACMHE(string EFINPLKEDMK, float INIEFLCMFEE = 0f, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E20430", Offset = "0x6E1EA30", VA = "0x186E20430", Slot = "18")]
	public NCFIDMFBOLI BCPHDDOPKKP(string EFINPLKEDMK, float MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E22300", Offset = "0x6E20900", VA = "0x186E22300", Slot = "19")]
	public DateTime ICBCEOLIPEI(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20A30", Offset = "0x6E1F030", VA = "0x186E20A30", Slot = "20")]
	public NCFIDMFBOLI BIJIFDLNCFC(string EFINPLKEDMK, DateTime MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E239A0", Offset = "0x6E21FA0", VA = "0x186E239A0", Slot = "21")]
	public long OHEDBBLONMG(string EFINPLKEDMK, long INIEFLCMFEE = 0L, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E21EA0", Offset = "0x6E204A0", VA = "0x186E21EA0", Slot = "22")]
	public NCFIDMFBOLI HLNKALHHJEP(string EFINPLKEDMK, long MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2301720", Offset = "0x22FFD20", VA = "0x182301720", Slot = "23")]
	public T KAGEPDPGAGE<T>(string EFINPLKEDMK, [Optional] T INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2301720", Offset = "0x22FFD20", VA = "0x182301720", Slot = "24")]
	public NCFIDMFBOLI OELKIENJIDM<T>(string EFINPLKEDMK, T MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E23080", Offset = "0x6E21680", VA = "0x186E23080", Slot = "25")]
	public bool MLMKNJPOOOH(string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E23440", Offset = "0x6E21A40", VA = "0x186E23440", Slot = "26")]
	public bool NOANGFIGOFG(string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E22A10", Offset = "0x6E21010", VA = "0x186E22A10", Slot = "27")]
	public string KJFCGJOPIHP(string EFINPLKEDMK, [Optional] string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E23050", Offset = "0x6E21650", VA = "0x186E23050", Slot = "28")]
	public NCFIDMFBOLI MLGJIGJBPIN(string EFINPLKEDMK, string MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E21E30", Offset = "0x6E20430", VA = "0x186E21E30", Slot = "29")]
	public int HEFJFEKGPLA(string EFINPLKEDMK, int INIEFLCMFEE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E22A80", Offset = "0x6E21080", VA = "0x186E22A80", Slot = "30")]
	public NCFIDMFBOLI KLDAJNMIPDE(string EFINPLKEDMK, int MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E21320", Offset = "0x6E1F920", VA = "0x186E21320", Slot = "31")]
	public bool EEMAMGOKMIK(string EFINPLKEDMK, bool INIEFLCMFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E20280", Offset = "0x6E1E880", VA = "0x186E20280", Slot = "32")]
	public NCFIDMFBOLI AIEPENLFOGG(string EFINPLKEDMK, bool MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E203C0", Offset = "0x6E1E9C0", VA = "0x186E203C0", Slot = "33")]
	public float AOLNJNPADHH(string EFINPLKEDMK, float INIEFLCMFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E22DF0", Offset = "0x6E213F0", VA = "0x186E22DF0", Slot = "34")]
	public NCFIDMFBOLI MEHKDNFADEM(string EFINPLKEDMK, float MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E23150", Offset = "0x6E21750", VA = "0x186E23150", Slot = "35")]
	public DateTime NCBABLHMKCG(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E20CF0", Offset = "0x6E1F2F0", VA = "0x186E20CF0", Slot = "36")]
	public NCFIDMFBOLI BMHDCCAMDAE(string EFINPLKEDMK, DateTime MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E230E0", Offset = "0x6E216E0", VA = "0x186E230E0", Slot = "37")]
	public long NAIAFBPDHGG(string EFINPLKEDMK, long INIEFLCMFEE = 0L)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E21150", Offset = "0x6E1F750", VA = "0x186E21150", Slot = "38")]
	public NCFIDMFBOLI CLNGMOJGBMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E21660", Offset = "0x6E1FC60", VA = "0x186E21660")]
	private bool GCHDJNDGNKK(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FFE0", Offset = "0x6E1E5E0", VA = "0x186E1FFE0")]
	private bool ABMCPLJJJKG(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E22C00", Offset = "0x6E21200", VA = "0x186E22C00")]
	private NCFIDMFBOLI LFKIINEHBKP(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, string MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E22540", Offset = "0x6E20B40", VA = "0x186E22540")]
	private NCFIDMFBOLI ILCIANFMKCD(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, int MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E20D20", Offset = "0x6E1F320", VA = "0x186E20D20")]
	private NCFIDMFBOLI CDDNAODHKNA(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, bool MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E21390", Offset = "0x6E1F990", VA = "0x186E21390")]
	private NCFIDMFBOLI EOCDHJJIPKD(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, float MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E22120", Offset = "0x6E20720", VA = "0x186E22120")]
	private NCFIDMFBOLI ICAILGIJHLL(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, DateTime MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E21C80", Offset = "0x6E20280", VA = "0x186E21C80")]
	private NCFIDMFBOLI GNFMJHAKBPN(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, long MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2301140", Offset = "0x22FF740", VA = "0x182301140")]
	private T COBDBGOHFEC<T>(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, T INIEFLCMFEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2300490", Offset = "0x22FEA90", VA = "0x182300490")]
	private NCFIDMFBOLI CBLGAEPDIOD<T>(DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, T MOLEJFDINLH)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2301930", Offset = "0x22FFF30", VA = "0x182301930", Slot = "39")]
	public void OBCFJAMBNGM<T>(ENKHNBEGBEI<T> LHDJHLIOMBE, [Optional] IEqualityComparer<T> OHDCMCANAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2301080", Offset = "0x22FF680", VA = "0x182301080", Slot = "40")]
	public void CNHIPABOKKJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E202B0", Offset = "0x6E1E8B0", VA = "0x186E202B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GMFNLBNOMBF))]
	private void AOLHMJCEMBO(DANHLLNBANE KKCEKAKADEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E22840", Offset = "0x6E20E40", VA = "0x186E22840", Slot = "43")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BHGJMENNOHH))]
	public Task JDALCKIAPIL([Optional] CancellationToken DCEGGIJLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E23450", Offset = "0x6E21A50", VA = "0x186E23450")]
	private void NOMENPDPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E226F0", Offset = "0x6E20CF0", VA = "0x186E226F0", Slot = "41")]
	public IDisposable INCEKLHEJMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E23C40", Offset = "0x6E22240", VA = "0x186E23C40", Slot = "42")]
	public void PEGCHBEIFEI(float MIKGPKAPCMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E23610", Offset = "0x6E21C10", VA = "0x186E23610")]
	private void NPAKJKCMBKG(float ANIJBFCMKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E22F70", Offset = "0x6E21570", VA = "0x186E22F70")]
	[IteratorStateMachine(typeof(HNPEFOLGMBK))]
	private IEnumerator<FOLOHDFBANO> MIONALEBGPI(float MIKGPKAPCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E22DC0", Offset = "0x6E213C0", VA = "0x186E22DC0")]
	[CompilerGenerated]
	private void MCHLPEPOKJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class GCPFKDEIJIN<TParent> where TParent : DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly HashSet<GCPFKDEIJIN<TParent>> OJKGNLJFPFD;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x24DDAD0", Offset = "0x24DC0D0", VA = "0x1824DDAD0")]
	protected GCPFKDEIJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract void FBJOPIHCMHF();

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void PLAPEOIKJJD(string BOMEFJIOGGM);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x24DD6F0", Offset = "0x24DBCF0", VA = "0x1824DD6F0")]
	public static void MAHKGILGFNG(string BOMEFJIOGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x24DD410", Offset = "0x24DBA10", VA = "0x1824DD410")]
	public static void BAAOMLFNNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KMPNAIHFIKN<TParent, TValue> : GCPFKDEIJIN<TParent> where TParent : DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly KMPNAIHFIKN<TParent, TValue> EOJNEJPDGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<string, TValue> FJGNFBEHDLJ;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2081570", Offset = "0x207FB70", VA = "0x182081570")]
	public bool PFDPJLFFHJD(string LKAJHHPOHHJ, out TValue INMMIDBIGIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x353DDE0", Offset = "0x353C3E0", VA = "0x18353DDE0")]
	public void MMFLEDFJHCF(string LKAJHHPOHHJ, TValue MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x24DD320", Offset = "0x24DB920", VA = "0x1824DD320", Slot = "4")]
	protected override void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x17B5700", Offset = "0x17B3D00", VA = "0x1817B5700", Slot = "5")]
	protected override void PLAPEOIKJJD(string LKAJHHPOHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x20C3CF0", Offset = "0x20C22F0", VA = "0x1820C3CF0")]
	public KMPNAIHFIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ODEHECDOOMA : GNELEDNOFJI, DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GKHJDFHLLJA : IAsyncStateMachine
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
		public ODEHECDOOMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public GKHJDFHLLJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DD30", Offset = "0x6E1C330", VA = "0x186E1DD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class BECAEMNOGBB : IEnumerator<FOLOHDFBANO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private FOLOHDFBANO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ODEHECDOOMA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private FOLOHDFBANO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public BECAEMNOGBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E19880", Offset = "0x6E17E80", VA = "0x186E19880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E198F0", Offset = "0x6E17EF0", VA = "0x186E198F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool KGKGIOLIGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private bool POMHDLOOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private CDNNNIJHPJN EBLGJABNHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private BDPNFFCBKDC PPPKDCOHIMO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FF00", Offset = "0x6E1E500", VA = "0x186E1FF00")]
	[Preserve]
	public ODEHECDOOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FAB0", Offset = "0x6E1E0B0", VA = "0x186E1FAB0", Slot = "6")]
	public Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26073E0", Offset = "0x26059E0", VA = "0x1826073E0")]
	private static int GGEIANNKBKC(bool MOLEJFDINLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD80", Offset = "0x6E1E380", VA = "0x186E1FD80", Slot = "9")]
	public bool NNNMNHGJFEH(string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4757830", Offset = "0x4755E30", VA = "0x184757830", Slot = "10")]
	public int JJJIKDHDLIN(string EFINPLKEDMK, int INIEFLCMFEE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x47576B0", Offset = "0x4755CB0", VA = "0x1847576B0", Slot = "11")]
	public void HGGJDPFGGPE(string EFINPLKEDMK, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD90", Offset = "0x6E1E390", VA = "0x186E1FD90", Slot = "12")]
	public bool OBDBCLKJNOJ(string EFINPLKEDMK, bool INIEFLCMFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD00", Offset = "0x6E1E300", VA = "0x186E1FD00", Slot = "13")]
	public void LKHNCACBGLO(string EFINPLKEDMK, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FB90", Offset = "0x6E1E190", VA = "0x186E1FB90", Slot = "14")]
	public float HAAGNNEMFDL(string EFINPLKEDMK, float INIEFLCMFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F8E0", Offset = "0x6E1DEE0", VA = "0x186E1F8E0", Slot = "15")]
	public void ALCFGKMCOPK(string EFINPLKEDMK, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FC70", Offset = "0x6E1E270", VA = "0x186E1FC70", Slot = "16")]
	public string KFNCGHMLMAI(string EFINPLKEDMK, string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FB70", Offset = "0x6E1E170", VA = "0x186E1FB70", Slot = "17")]
	public void GNFDJCHKCBE(string EFINPLKEDMK, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FE20", Offset = "0x6E1E420", VA = "0x186E1FE20", Slot = "18")]
	public DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD10", Offset = "0x6E1E310", VA = "0x186E1FD10", Slot = "19")]
	public void NKHONKMAPKF(string EFINPLKEDMK, DateTime LLALBNBPBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FBA0", Offset = "0x6E1E1A0", VA = "0x186E1FBA0", Slot = "20")]
	public long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FDB0", Offset = "0x6E1E3B0", VA = "0x186E1FDB0", Slot = "21")]
	public void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "22")]
	public T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "23")]
	public void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x22EACB0", Offset = "0x22E92B0", VA = "0x1822EACB0")]
	private T ABACBNPBAJH<T>(string EFINPLKEDMK, T INIEFLCMFEE, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x22EB910", Offset = "0x22E9F10", VA = "0x1822EB910")]
	private void GEIJHIJPDAK<T>(string EFINPLKEDMK, T MOLEJFDINLH, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FA40", Offset = "0x6E1E040", VA = "0x186E1FA40", Slot = "24")]
	public void CCGHLBADJDF(string EFINPLKEDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F8F0", Offset = "0x6E1DEF0", VA = "0x186E1F8F0", Slot = "25")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GKHJDFHLLJA))]
	public Task AOLHMJCEMBO(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FB00", Offset = "0x6E1E100", VA = "0x186E1FB00")]
	[IteratorStateMachine(typeof(BECAEMNOGBB))]
	private IEnumerator<FOLOHDFBANO> FLPLDPKMCAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FC10", Offset = "0x6E1E210", VA = "0x186E1FC10")]
	private void JDALCKIAPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FE90", Offset = "0x6E1E490", VA = "0x186E1FE90")]
	private void PHNKPNOJDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FC90", Offset = "0x6E1E290", VA = "0x186E1FC90")]
	private void LJEJJNFHDLO(bool GHGOAJFOICO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal static class FHDHDBNLMED
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D210", Offset = "0x6E1B810", VA = "0x186E1D210")]
	[HFALCAKMDCP(BFPOMPMIJIJ.None)]
	private static void MNBLCDKPKOL(HOKFDAHMIPF IBEPDAFMEAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class DHMLIJNOBAI : GNELEDNOFJI, DANHLLNBANE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly Dictionary<string, byte> LHLPNELOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Dictionary<string, string> EKMHMBEBEML;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Dictionary<string, string> GPAJFMOBPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B7B0", Offset = "0x6E19DB0", VA = "0x186E1B7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CB80", Offset = "0x6E1B180", VA = "0x186E1CB80")]
	[Preserve]
	public DHMLIJNOBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BA20", Offset = "0x6E1A020", VA = "0x186E1BA20")]
	private DirectoryInfo JLBGMCPNGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B760", Offset = "0x6E19D60", VA = "0x186E1B760", Slot = "6")]
	public Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B860", Offset = "0x6E19E60", VA = "0x186E1B860", Slot = "14")]
	public float HAAGNNEMFDL(string BOMEFJIOGGM, float INIEFLCMFEE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BBA0", Offset = "0x6E1A1A0", VA = "0x186E1BBA0", Slot = "13")]
	public void LKHNCACBGLO(string BOMEFJIOGGM, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C4B0", Offset = "0x6E1AAB0", VA = "0x186E1C4B0", Slot = "12")]
	public bool OBDBCLKJNOJ(string BOMEFJIOGGM, bool INIEFLCMFEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B9B0", Offset = "0x6E19FB0", VA = "0x186E1B9B0", Slot = "10")]
	public int JJJIKDHDLIN(string BOMEFJIOGGM, int INIEFLCMFEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C7F0", Offset = "0x6E1ADF0", VA = "0x186E1C7F0", Slot = "18")]
	public DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C3B0", Offset = "0x6E1A9B0", VA = "0x186E1C3B0", Slot = "19")]
	public void NKHONKMAPKF(string BOMEFJIOGGM, DateTime MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B200", Offset = "0x6E19800", VA = "0x186E1B200", Slot = "15")]
	public void ALCFGKMCOPK(string BOMEFJIOGGM, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B8D0", Offset = "0x6E19ED0", VA = "0x186E1B8D0", Slot = "11")]
	public void HGGJDPFGGPE(string BOMEFJIOGGM, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B940", Offset = "0x6E19F40", VA = "0x186E1B940", Slot = "20")]
	public long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C5A0", Offset = "0x6E1ABA0", VA = "0x186E1C5A0", Slot = "21")]
	public void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "22")]
	public T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0xF3B050", Offset = "0xF39650", VA = "0x180F3B050", Slot = "23")]
	public void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BAF0", Offset = "0x6E1A0F0", VA = "0x186E1BAF0", Slot = "16")]
	public string KFNCGHMLMAI(string BOMEFJIOGGM, string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B7F0", Offset = "0x6E19DF0", VA = "0x186E1B7F0", Slot = "17")]
	public void GNFDJCHKCBE(string BOMEFJIOGGM, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B680", Offset = "0x6E19C80", VA = "0x186E1B680", Slot = "24")]
	public void CCGHLBADJDF(string BOMEFJIOGGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C420", Offset = "0x6E1AA20", VA = "0x186E1C420", Slot = "9")]
	public bool NNNMNHGJFEH(string BOMEFJIOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B270", Offset = "0x6E19870", VA = "0x186E1B270", Slot = "25")]
	public Task AOLHMJCEMBO(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C860", Offset = "0x6E1AE60", VA = "0x186E1C860")]
	private void PKNHIEDKJHN(DirectoryInfo AOAODGAEKEN, string BEKJJAOKEHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C610", Offset = "0x6E1AC10", VA = "0x186E1C610")]
	private static string OOPENPMLPEI(string BOMEFJIOGGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B580", Offset = "0x6E19B80", VA = "0x186E1B580")]
	private static string CAMBGJCJNMO(byte[] DOOPBMHHDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24400C0", Offset = "0x243E6C0", VA = "0x1824400C0")]
	private T MBNHJLNEIKL<T>(string EFINPLKEDMK, T INIEFLCMFEE, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x243EB50", Offset = "0x243D150", VA = "0x18243EB50")]
	private void FGMAFKALEHD<T>(string EFINPLKEDMK, T MOLEJFDINLH, [Optional] ENKHNBEGBEI<T> GFOAEAMDGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BC10", Offset = "0x6E1A210", VA = "0x186E1BC10")]
	private Dictionary<string, string> MLEOIIFADOA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface OEDCEGNGFJP
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action FMHHEPIIFPA;

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBIJAFOMEOH();

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task BDFELCLANEC(long DMCPHLADIOL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DMMCIOACNHA(KONOJAHEIKM ALIADLJIBBE = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OCDNJLMNHHE(string EFINPLKEDMK, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GFBJMPNGBBL(string EFINPLKEDMK, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	string OINJPPBJMPG(string EFINPLKEDMK, [Optional] string INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NCFIDMFBOLI GKBKBHCNDDN(string EFINPLKEDMK, string MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int MIMDPLFIFOM(string EFINPLKEDMK, int INIEFLCMFEE = 0, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NCFIDMFBOLI CGOOHOENGCE(string EFINPLKEDMK, int MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ACAJLIJMFLD(string EFINPLKEDMK, bool INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	NCFIDMFBOLI NKGFINKBLCH(string EFINPLKEDMK, bool MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float LCLFNKACMHE(string EFINPLKEDMK, float INIEFLCMFEE = 0f, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NCFIDMFBOLI BCPHDDOPKKP(string EFINPLKEDMK, float MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DateTime ICBCEOLIPEI(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	NCFIDMFBOLI BIJIFDLNCFC(string EFINPLKEDMK, DateTime MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	long OHEDBBLONMG(string EFINPLKEDMK, long INIEFLCMFEE = 0L, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NCFIDMFBOLI HLNKALHHJEP(string EFINPLKEDMK, long MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	T KAGEPDPGAGE<T>(string EFINPLKEDMK, [Optional] T INIEFLCMFEE, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	NCFIDMFBOLI OELKIENJIDM<T>(string EFINPLKEDMK, T MOLEJFDINLH, KONOJAHEIKM IDGMBDOAEIK = KONOJAHEIKM.CLOUD);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool MLMKNJPOOOH(string EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "22")]
	bool NOANGFIGOFG(string EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	string KJFCGJOPIHP(string EFINPLKEDMK, [Optional] string INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NCFIDMFBOLI MLGJIGJBPIN(string EFINPLKEDMK, string MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	int HEFJFEKGPLA(string EFINPLKEDMK, int INIEFLCMFEE = 0);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NCFIDMFBOLI KLDAJNMIPDE(string EFINPLKEDMK, int MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool EEMAMGOKMIK(string EFINPLKEDMK, bool INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NCFIDMFBOLI AIEPENLFOGG(string EFINPLKEDMK, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	float AOLNJNPADHH(string EFINPLKEDMK, float INIEFLCMFEE = 0f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	NCFIDMFBOLI MEHKDNFADEM(string EFINPLKEDMK, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	DateTime NCBABLHMKCG(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	NCFIDMFBOLI BMHDCCAMDAE(string EFINPLKEDMK, DateTime MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	long NAIAFBPDHGG(string EFINPLKEDMK, long INIEFLCMFEE = 0L);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	NCFIDMFBOLI CLNGMOJGBMN(string EFINPLKEDMK, long MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void OBCFJAMBNGM<T>(ENKHNBEGBEI<T> LHDJHLIOMBE, [Optional] IEqualityComparer<T> OHDCMCANAGL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CNHIPABOKKJ<T>();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IDisposable INCEKLHEJMC();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PEGCHBEIFEI(float MIKGPKAPCMA);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task JDALCKIAPIL([Optional] CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum NCFIDMFBOLI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	Unchanged,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	New,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Changed
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBIJAFOMEOH();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NNNMNHGJFEH(string EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JJJIKDHDLIN(string EFINPLKEDMK, int INIEFLCMFEE = 0);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGGJDPFGGPE(string EFINPLKEDMK, int MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBDBCLKJNOJ(string EFINPLKEDMK, bool INIEFLCMFEE = false);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LKHNCACBGLO(string EFINPLKEDMK, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "7")]
	float HAAGNNEMFDL(string EFINPLKEDMK, float INIEFLCMFEE = 0f);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ALCFGKMCOPK(string EFINPLKEDMK, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	string KFNCGHMLMAI(string EFINPLKEDMK, [Optional] string INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNFDJCHKCBE(string EFINPLKEDMK, string MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime LLALBNBPBAO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NKHONKMAPKF(string EFINPLKEDMK, DateTime LLALBNBPBAO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CCGHLBADJDF(string EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task AOLHMJCEMBO([Optional] CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GNELEDNOFJI : DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action FMHHEPIIFPA;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BECEAGKCLKN : DANHLLNBANE
{
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LGFDKHHLJOD : PBMGMKHMGOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F860", Offset = "0x6E1DE60", VA = "0x186E1F860")]
	[Preserve]
	public LGFDKHHLJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CKLGOEDFFGC : GNELEDNOFJI, DANHLLNBANE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class CHNBLKBMCOH : IAsyncStateMachine
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
		public CKLGOEDFFGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public CHNBLKBMCOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6E19E60", Offset = "0x6E18460", VA = "0x186E19E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class IDDGNDNMFPJ : IAsyncStateMachine
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
		public CKLGOEDFFGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public IDDGNDNMFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E4D0", Offset = "0x6E1CAD0", VA = "0x186E1E4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly GNELEDNOFJI FENLKNGOBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly DHMLIJNOBAI PLHIFNANADN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6E1AC30", Offset = "0x6E19230", VA = "0x186E1AC30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A470", Offset = "0x6E18A70", VA = "0x186E1A470", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A400", Offset = "0x6E18A00", VA = "0x186E1A400", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B120", Offset = "0x6E19720", VA = "0x186E1B120")]
	[Preserve]
	public CKLGOEDFFGC(GNELEDNOFJI FENLKNGOBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A870", Offset = "0x6E18E70", VA = "0x186E1A870", Slot = "8")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AD00", Offset = "0x6E19300", VA = "0x186E1AD00", Slot = "9")]
	public bool NNNMNHGJFEH(string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A8D0", Offset = "0x6E18ED0", VA = "0x186E1A8D0", Slot = "10")]
	public int JJJIKDHDLIN(string EFINPLKEDMK, int INIEFLCMFEE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A6A0", Offset = "0x6E18CA0", VA = "0x186E1A6A0", Slot = "11")]
	public void HGGJDPFGGPE(string EFINPLKEDMK, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AD90", Offset = "0x6E19390", VA = "0x186E1AD90", Slot = "12")]
	public bool OBDBCLKJNOJ(string EFINPLKEDMK, bool INIEFLCMFEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ABC0", Offset = "0x6E191C0", VA = "0x186E1ABC0", Slot = "13")]
	public void LKHNCACBGLO(string EFINPLKEDMK, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A540", Offset = "0x6E18B40", VA = "0x186E1A540", Slot = "14")]
	public float HAAGNNEMFDL(string EFINPLKEDMK, float INIEFLCMFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E19FC0", Offset = "0x6E185C0", VA = "0x186E19FC0", Slot = "15")]
	public void ALCFGKMCOPK(string EFINPLKEDMK, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AA30", Offset = "0x6E19030", VA = "0x186E1AA30", Slot = "16")]
	public string KFNCGHMLMAI(string EFINPLKEDMK, [Optional] string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A4D0", Offset = "0x6E18AD0", VA = "0x186E1A4D0", Slot = "17")]
	public void GNFDJCHKCBE(string EFINPLKEDMK, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AFC0", Offset = "0x6E195C0", VA = "0x186E1AFC0", Slot = "18")]
	public DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AC90", Offset = "0x6E19290", VA = "0x186E1AC90", Slot = "19")]
	public void NKHONKMAPKF(string EFINPLKEDMK, DateTime LLALBNBPBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A710", Offset = "0x6E18D10", VA = "0x186E1A710", Slot = "20")]
	public long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AF50", Offset = "0x6E19550", VA = "0x186E1AF50", Slot = "21")]
	public void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x191DD50", Offset = "0x191C350", VA = "0x18191DD50", Slot = "22")]
	public T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x191E3D0", Offset = "0x191C9D0", VA = "0x18191E3D0", Slot = "23")]
	public void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A180", Offset = "0x6E18780", VA = "0x186E1A180", Slot = "24")]
	public void CCGHLBADJDF(string EFINPLKEDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A030", Offset = "0x6E18630", VA = "0x186E1A030", Slot = "25")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CHNBLKBMCOH))]
	public Task AOLHMJCEMBO([Optional] CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A2A0", Offset = "0x6E188A0", VA = "0x186E1A2A0", Slot = "6")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IDDGNDNMFPJ))]
	public Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PBMGMKHMGOJ : GNELEDNOFJI, DANHLLNBANE, BECEAGKCLKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly Dictionary<string, object> LEEBKHNPNFB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action FMHHEPIIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
	public void JBIJAFOMEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E23FA0", Offset = "0x6E225A0", VA = "0x186E23FA0", Slot = "6")]
	public Task DBLHCGMPIHO(long DMCPHLADIOL, CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6E242F0", Offset = "0x6E228F0", VA = "0x186E242F0", Slot = "9")]
	public bool NNNMNHGJFEH(string EFINPLKEDMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E24170", Offset = "0x6E22770", VA = "0x186E24170", Slot = "10")]
	public int JJJIKDHDLIN(string EFINPLKEDMK, int INIEFLCMFEE = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E240B0", Offset = "0x6E226B0", VA = "0x186E240B0", Slot = "11")]
	public void HGGJDPFGGPE(string EFINPLKEDMK, int MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6E24350", Offset = "0x6E22950", VA = "0x186E24350", Slot = "12")]
	public bool OBDBCLKJNOJ(string EFINPLKEDMK, bool INIEFLCMFEE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6E24230", Offset = "0x6E22830", VA = "0x186E24230", Slot = "13")]
	public void LKHNCACBGLO(string EFINPLKEDMK, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6E24050", Offset = "0x6E22650", VA = "0x186E24050", Slot = "14")]
	public float HAAGNNEMFDL(string EFINPLKEDMK, float INIEFLCMFEE = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E23E90", Offset = "0x6E22490", VA = "0x186E23E90", Slot = "15")]
	public void ALCFGKMCOPK(string EFINPLKEDMK, float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6E241D0", Offset = "0x6E227D0", VA = "0x186E241D0", Slot = "16")]
	public string KFNCGHMLMAI(string EFINPLKEDMK, [Optional] string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E23FF0", Offset = "0x6E225F0", VA = "0x186E23FF0", Slot = "17")]
	public void GNFDJCHKCBE(string EFINPLKEDMK, string MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6E24410", Offset = "0x6E22A10", VA = "0x186E24410", Slot = "18")]
	public DateTime PDKAKHDACGC(string EFINPLKEDMK, [Optional] DateTime INIEFLCMFEE)
	{
		return default(DateTime);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E24290", Offset = "0x6E22890", VA = "0x186E24290", Slot = "19")]
	public void NKHONKMAPKF(string EFINPLKEDMK, DateTime MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E24110", Offset = "0x6E22710", VA = "0x186E24110", Slot = "20")]
	public long IPEHIBFEIMO(string EFINPLKEDMK, long INIEFLCMFEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E243B0", Offset = "0x6E229B0", VA = "0x186E243B0", Slot = "21")]
	public void OIGCOFDBEMN(string EFINPLKEDMK, long MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x2305980", Offset = "0x2303F80", VA = "0x182305980", Slot = "22")]
	public T JGFALKCDEMK<T>(string EFINPLKEDMK, T INIEFLCMFEE, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2305980", Offset = "0x2303F80", VA = "0x182305980", Slot = "23")]
	public void NGAPEMBBFGN<T>(string EFINPLKEDMK, T MOLEJFDINLH, ENKHNBEGBEI<T> LHDJHLIOMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2305A90", Offset = "0x2304090", VA = "0x182305A90")]
	public T MBNHJLNEIKL<T>(string EFINPLKEDMK, T INIEFLCMFEE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2305490", Offset = "0x2303A90", VA = "0x182305490")]
	public void FGMAFKALEHD<T>(string EFINPLKEDMK, T MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E23F40", Offset = "0x6E22540", VA = "0x186E23F40", Slot = "24")]
	public void CCGHLBADJDF(string EFINPLKEDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E23EF0", Offset = "0x6E224F0", VA = "0x186E23EF0", Slot = "25")]
	public Task AOLHMJCEMBO(CancellationToken KEGMOCPJOHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F860", Offset = "0x6E1DE60", VA = "0x186E1F860")]
	public PBMGMKHMGOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KONOJAHEIKM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CLOUD,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	DISK
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class GBFCAGINDIE
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D610", Offset = "0x6E1BC10", VA = "0x186E1D610")]
	private static void GODPNFIFANP(DANHLLNBANE AEAJFPAFAJK, Action<DANHLLNBANE> OFMMDEAJAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DC30", Offset = "0x6E1C230", VA = "0x186E1DC30")]
	public static bool PPMFGJFFMJJ(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D360", Offset = "0x6E1B960", VA = "0x186E1D360")]
	public static NCFIDMFBOLI ADEGGGPOCPE(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, string MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D6A0", Offset = "0x6E1BCA0", VA = "0x186E1D6A0")]
	public static NCFIDMFBOLI GPIBPLNEJME(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, int MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D4C0", Offset = "0x6E1BAC0", VA = "0x186E1D4C0")]
	public static NCFIDMFBOLI DCACDHJFNME(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, bool MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D7F0", Offset = "0x6E1BDF0", VA = "0x186E1D7F0")]
	public static NCFIDMFBOLI IHLKGCBGKOF(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, float MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D950", Offset = "0x6E1BF50", VA = "0x186E1D950")]
	public static NCFIDMFBOLI IOKHGENCCOF(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, DateTime MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DAE0", Offset = "0x6E1C0E0", VA = "0x186E1DAE0")]
	public static NCFIDMFBOLI NNHDAOBPNBH(this DANHLLNBANE AEAJFPAFAJK, string EFINPLKEDMK, long MOLEJFDINLH, [Optional] Action<DANHLLNBANE> OFMMDEAJAOO)
	{
		return default(NCFIDMFBOLI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EGOOODFJEFK : DMLEKLJDECG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static EGOOODFJEFK HAMPJMKDJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6E1D010", Offset = "0x6E1B610", VA = "0x186E1D010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CF20", Offset = "0x6E1B520", VA = "0x186E1CF20", Slot = "9")]
	public override string HLDMGFBCHDH(bool JDCGNJBJHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CC00", Offset = "0x6E1B200", VA = "0x186E1CC00", Slot = "10")]
	protected override bool EFPKEPJKIEI(string JDCGNJBJHCM, out bool MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D0F0", Offset = "0x6E1B6F0", VA = "0x186E1D0F0")]
	public EGOOODFJEFK()
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
