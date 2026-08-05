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
public interface IBOHNMNOADL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	TimeSpan NHIJNDLKKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x259500802594D0", Offset = "0x0", VA = "0x259502002594D0", Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AAHNIAIJPIP<TConfig> : CJFGELOCMFD<TConfig> where TConfig : IBOHNMNOADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ADDKFEMCNPG<TConfig> CLMMDINICLM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x312A500", Offset = "0x3129900", VA = "0x18312A500")]
	[Preserve]
	public AAHNIAIJPIP([JLJFOFICIEA(null)] GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x312A340", Offset = "0x3129740", VA = "0x18312A340", Slot = "12")]
	public override void DJELCEFPDKK(TConfig PPCPEOGMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x312A370", Offset = "0x3129770", VA = "0x18312A370", Slot = "13")]
	protected override void GLINDFMMGLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class CJFGELOCMFD<TConfig> : ACMKBGEHJKE<TConfig> where TConfig : IBOHNMNOADL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class MIHEBJKHFDJ : IEnumerator<PHFLFKPMCCG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private PHFLFKPMCCG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CJFGELOCMFD<TConfig> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private GGDNLKAAGIA <schedulerTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KMAJPHOAMBK <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private PHFLFKPMCCG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x19DEBC0", Offset = "0x19DDFC0", VA = "0x1819DEBC0")]
		[DebuggerHidden]
		public MIHEBJKHFDJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2C00380", Offset = "0x2BFF780", VA = "0x182C00380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2C00520", Offset = "0x2BFF920", VA = "0x182C00520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	protected readonly GNILGMCMPBL NEELIDMCIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly GLMKJHJBJDA MKLFABCCCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private IMJDOMFMBGH CMGCHDNDGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool LPBGICMOBDM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public TimeSpan MBAPNECLGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected bool JAOOKOKJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9747D0", Offset = "0x973BD0", VA = "0x1809747D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ACMKBGEHJKE<TConfig>.EBNHMMGLJOD AGLJNOADNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x349B700", Offset = "0x349AB00", VA = "0x18349B700", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x349B900", Offset = "0x349AD00", VA = "0x18349B900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event ACMKBGEHJKE<TConfig>.IHNHMPHICEM CLOBFABOKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x349B640", Offset = "0x349AA40", VA = "0x18349B640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x349B4D0", Offset = "0x349A8D0", VA = "0x18349B4D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x349B9C0", Offset = "0x349ADC0", VA = "0x18349B9C0")]
	public CJFGELOCMFD(GNILGMCMPBL NEELIDMCIKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x349B5B0", Offset = "0x349A9B0", VA = "0x18349B5B0")]
	[IteratorStateMachine(typeof(CJFGELOCMFD<>.MIHEBJKHFDJ))]
	private IEnumerator<PHFLFKPMCCG> ICAMFGHPHKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void DJELCEFPDKK(TConfig PPCPEOGMHIJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x349B7E0", Offset = "0x349ABE0", VA = "0x18349B7E0", Slot = "11")]
	public void OPKOFIPIHJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9745D0", Offset = "0x9739D0", VA = "0x1809745D0", Slot = "8")]
	public void BLGKAIADOCH(object PKAPJAGGGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x9745F0", Offset = "0x9739F0", VA = "0x1809745F0", Slot = "10")]
	public void CFPGJBOMJMB(object PKAPJAGGGFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "13")]
	protected abstract void GLINDFMMGLK();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x349B7C0", Offset = "0x349ABC0", VA = "0x18349B7C0")]
	protected void NEGNBONENPO(TConfig PPCPEOGMHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x349B590", Offset = "0x349A990", VA = "0x18349B590")]
	protected void FGPAIGJCFLE(TConfig PPCPEOGMHIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ACMKBGEHJKE<TConfig> where TConfig : IBOHNMNOADL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void EBNHMMGLJOD(TConfig PPCPEOGMHIJ);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public delegate void IHNHMPHICEM(TConfig PPCPEOGMHIJ);

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EBNHMMGLJOD AGLJNOADNLN;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event IHNHMPHICEM CLOBFABOKAO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLGKAIADOCH(object PKAPJAGGGFP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJELCEFPDKK(TConfig PPCPEOGMHIJ);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CFPGJBOMJMB(object PKAPJAGGGFP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPKOFIPIHJD();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class ADDKFEMCNPG<TConfig> where TConfig : IBOHNMNOADL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly GGDNLKAAGIA INJHLEJHFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Queue<TConfig> CLAOAKAOJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private float PKAMFDMBFOO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public TConfig LIBPOBHNCHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return (TConfig)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FCHGOAAAGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x901ED0", Offset = "0x9012D0", VA = "0x180901ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CIKANKFPLIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3137C10", Offset = "0x3137010", VA = "0x183137C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool GFKGCKJFNCH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2E681C0", Offset = "0x2E675C0", VA = "0x182E681C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3137DD0", Offset = "0x31371D0", VA = "0x183137DD0")]
	public ADDKFEMCNPG(GGDNLKAAGIA INJHLEJHFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3137B80", Offset = "0x3136F80", VA = "0x183137B80")]
	public void ABKLHIDIBMJ(TConfig FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3137BB0", Offset = "0x3136FB0", VA = "0x183137BB0")]
	public void EHBAJMLMIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x3137C60", Offset = "0x3137060", VA = "0x183137C60")]
	public void NJCJKFBLGMI()
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
