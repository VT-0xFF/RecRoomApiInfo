using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OMMBEKCLGBB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DBLHBCFHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KKOHOKKIPHA> ALHNLNOLFMB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KKOHOKKIPHA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AMLIJCHMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MEJIMCINABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HNKLEIDOEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKFGLBLJMJM JLLIACJJHHN(Action<ArraySegment<float>> PJJEKPONKPF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFCKDHAMGNG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DKFGLBLJMJM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GPPIPLGDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GLEPIOGJGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x208FBA0", Offset = "0x208E9A0", VA = "0x18208FBA0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x52E5350", Offset = "0x52E4150", VA = "0x1852E5350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6502C00", Offset = "0x6501A00", VA = "0x186502C00")]
	public DKFGLBLJMJM(int IGIFOOLMDMB, int HLDOODPIBAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BCJGMBHJMJJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OMMBEKCLGBB MHPOANLMMBL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DBLHBCFHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6502A90", Offset = "0x6501890", VA = "0x186502A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6502B10", Offset = "0x6501910", VA = "0x186502B10")]
	static BCJGMBHJMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65029A0", Offset = "0x65017A0", VA = "0x1865029A0")]
	public static IReadOnlyList<KKOHOKKIPHA> ALHNLNOLFMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKDMHBMLIPC : OMMBEKCLGBB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MDEBPFJJGAP : KKOHOKKIPHA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FLFGNNANLCD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
			public FLFGNNANLCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6502FC0", Offset = "0x6501DC0", VA = "0x186502FC0")]
			internal void LHLELCMHEMH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NEDFGMCNGCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ILOMKABOLML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BKHKAKOHCCA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AMLIJCHMEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x65035B0", Offset = "0x65023B0", VA = "0x1865035B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MEJIMCINABP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x81DA80", Offset = "0x81C880", VA = "0x18081DA80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D53A0", Offset = "0x8D41A0", VA = "0x1808D53A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HNKLEIDOEOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC0FC90", Offset = "0xC0EA90", VA = "0x180C0FC90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65031C0", Offset = "0x6501FC0", VA = "0x1865031C0", Slot = "7")]
		public DKFGLBLJMJM JLLIACJJHHN(Action<ArraySegment<float>> PJJEKPONKPF)
		{
			return default(DKFGLBLJMJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65031F0", Offset = "0x6501FF0", VA = "0x1865031F0")]
		private DKFGLBLJMJM JLLIACJJHHN(int IGIFOOLMDMB, int KKELDBLPAGI, int HLDOODPIBAA, Action<ArraySegment<float>> PJJEKPONKPF)
		{
			return default(DKFGLBLJMJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6503140", Offset = "0x6501F40", VA = "0x186503140", Slot = "8")]
		public void AFCKDHAMGNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65035D0", Offset = "0x65023D0", VA = "0x1865035D0")]
		public MDEBPFJJGAP(MMDevice NEDFGMCNGCI, bool IINGONENKKB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MDEBPFJJGAP> PFJAENLJNPE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DBLHBCFHBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6502C10", Offset = "0x6501A10", VA = "0x186502C10", Slot = "5")]
	public IReadOnlyList<KKOHOKKIPHA> ALHNLNOLFMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6502F30", Offset = "0x6501D30", VA = "0x186502F30")]
	public EKDMHBMLIPC()
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
