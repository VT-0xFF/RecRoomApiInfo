using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface NPOKMLDGMDI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan DAAFNKIBGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x24ED4E8897997C", Offset = "0x0", VA = "0x24ED500897997C", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class HMPKOFOFAJP<TConfig> : DEGAOOAJBJF<TConfig> where TConfig : NPOKMLDGMDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HIFFAAPMIEA<TConfig> IDAEMMBINJF;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE7C0", Offset = "0x2DADBC0", VA = "0x182DAE7C0")]
	[Preserve]
	public HMPKOFOFAJP([EPGFAMNCJKC(null)] PKBGBEDEGAH BEIHHMBEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE790", Offset = "0x2DADB90", VA = "0x182DAE790", Slot = "12")]
	public override void DMPMNAPACFG(TConfig DPEGKOHKGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DAE600", Offset = "0x2DADA00", VA = "0x182DAE600", Slot = "13")]
	protected override void COCGDBGCNKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class DEGAOOAJBJF<TConfig> : FCGLBJGJHBP<TConfig> where TConfig : NPOKMLDGMDI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IBAAAKMFLLK : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private LJHFBCJIPCN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public DEGAOOAJBJF<TConfig> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private FCHPHMFHDKK <schedulerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private PIILPINONBB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1A389D0", Offset = "0x1A37DD0", VA = "0x181A389D0")]
		[DebuggerHidden]
		public IBAAAKMFLLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5AE2EB0", Offset = "0x5AE22B0", VA = "0x185AE2EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5AE3050", Offset = "0x5AE2450", VA = "0x185AE3050", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly PKBGBEDEGAH BEIHHMBEGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LMDJEEFCDOJ IANAKGCGCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private ODDHCGCOHBO PFHGCDAJLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool BOCJDBOGLBC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TimeSpan AAFNLABNBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected bool FOGDFJJHBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BCE00", Offset = "0x9BC200", VA = "0x1809BCE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FCGLBJGJHBP<TConfig>.PAGGLJDOEON HFMDMLKICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D330", Offset = "0x2B0C730", VA = "0x182B0D330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D270", Offset = "0x2B0C670", VA = "0x182B0D270", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FCGLBJGJHBP<TConfig>.JHNMKLELAJL NEBKJKPKIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D630", Offset = "0x2B0CA30", VA = "0x182B0D630", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2B0D1B0", Offset = "0x2B0C5B0", VA = "0x182B0D1B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D6F0", Offset = "0x2B0CAF0", VA = "0x182B0D6F0")]
	public DEGAOOAJBJF(PKBGBEDEGAH BEIHHMBEGCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D580", Offset = "0x2B0C980", VA = "0x182B0D580")]
	[IteratorStateMachine(typeof(DEGAOOAJBJF<>.IBAAAKMFLLK))]
	private IEnumerator<LJHFBCJIPCN> HHCLIJPBCGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void DMPMNAPACFG(TConfig DPEGKOHKGDO);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D3F0", Offset = "0x2B0C7F0", VA = "0x182B0D3F0", Slot = "11")]
	public void ENLGDLEAANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9BC9E0", Offset = "0x9BBDE0", VA = "0x1809BC9E0", Slot = "8")]
	public void HDPOAHOFEMM(object BJLPNFHENEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9BCC20", Offset = "0x9BC020", VA = "0x1809BCC20", Slot = "10")]
	public void BNPGEAPOILP(object BJLPNFHENEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	protected abstract void COCGDBGCNKP();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D610", Offset = "0x2B0CA10", VA = "0x182B0D610")]
	protected void JMOBCGLEABG(TConfig DPEGKOHKGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D190", Offset = "0x2B0C590", VA = "0x182B0D190")]
	protected void ABOFFDNHBEB(TConfig DPEGKOHKGDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FCGLBJGJHBP<TConfig> where TConfig : NPOKMLDGMDI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void PAGGLJDOEON(TConfig DPEGKOHKGDO);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void JHNMKLELAJL(TConfig DPEGKOHKGDO);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event PAGGLJDOEON HFMDMLKICPJ;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JHNMKLELAJL NEBKJKPKIAG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDPOAHOFEMM(object BJLPNFHENEO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMPMNAPACFG(TConfig DPEGKOHKGDO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNPGEAPOILP(object BJLPNFHENEO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ENLGDLEAANC();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class HIFFAAPMIEA<TConfig> where TConfig : NPOKMLDGMDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly FCHPHMFHDKK ADGMBKKGEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Queue<TConfig> KCAHGNNGIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private float MALEGGAPEKM;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TConfig OODJIJAGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return (TConfig)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PGNNAPKJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9937F0", Offset = "0x992BF0", VA = "0x1809937F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x992D00", Offset = "0x992100", VA = "0x180992D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OKIJHGAHBPC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x20367B0", Offset = "0x2035BB0", VA = "0x1820367B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool HBJLFBKBDIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x202C890", Offset = "0x202BC90", VA = "0x18202C890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2036A00", Offset = "0x2035E00", VA = "0x182036A00")]
	public HIFFAAPMIEA(FCHPHMFHDKK ADGMBKKGEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20369D0", Offset = "0x2035DD0", VA = "0x1820369D0")]
	public void NJAKMDPDEFJ(TConfig HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2036800", Offset = "0x2035C00", VA = "0x182036800")]
	public void HJNMIJNAGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2036860", Offset = "0x2035C60", VA = "0x182036860")]
	public void MILEHAFFCGP()
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
