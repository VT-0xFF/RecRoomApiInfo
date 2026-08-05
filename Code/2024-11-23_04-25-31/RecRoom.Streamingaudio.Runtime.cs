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
public interface NKLODIAGBGC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GGHJENNMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OJCJBDJJEEC> DOANOMOCKFK();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OJCJBDJJEEC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GMKJCBCMFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HGAPNOJPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MMCIPHMHOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOFHFENOMKN PELBLHFDHFE(Action<ArraySegment<float>> HFJNADOBPEL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBIJMHCDKNH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OOFHFENOMKN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BLIFBPKMJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x982700", Offset = "0x981100", VA = "0x180982700")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC9FF70", Offset = "0xC9E970", VA = "0x180C9FF70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DENBKCFKAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x286D5C0", Offset = "0x286BFC0", VA = "0x18286D5C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x617B8C0", Offset = "0x617A2C0", VA = "0x18617B8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E432D0", Offset = "0x6E41CD0", VA = "0x186E432D0")]
	public OOFHFENOMKN(int OCDAAEPIOAN, int EKLCNDFMPFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BFDPALEDJBP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NKLODIAGBGC KBKHCCJFGMA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GGHJENNMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77A4B70", Offset = "0x77A3570", VA = "0x1877A4B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77A4CD0", Offset = "0x77A36D0", VA = "0x1877A4CD0")]
	static BFDPALEDJBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77A4BE0", Offset = "0x77A35E0", VA = "0x1877A4BE0")]
	public static IReadOnlyList<OJCJBDJJEEC> DOANOMOCKFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CPGDABNKCPJ : NKLODIAGBGC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JJDPJLALPDN : OJCJBDJJEEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FKLCGOFLLHI
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
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public FKLCGOFLLHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x77A5170", Offset = "0x77A3B70", VA = "0x1877A5170")]
			internal void PAKIMGIMDBM(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EFOJMAFPEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HGIGELGPAIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MJOBKDFCECE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GMKJCBCMFOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x77A52F0", Offset = "0x77A3CF0", VA = "0x1877A52F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HGAPNOJPBPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A2DD0", Offset = "0x9A17D0", VA = "0x1809A2DD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C90", Offset = "0x9A1690", VA = "0x1809A2C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MMCIPHMHOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x93E180", Offset = "0x93CB80", VA = "0x18093E180", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77A5750", Offset = "0x77A4150", VA = "0x1877A5750", Slot = "7")]
		public OOFHFENOMKN PELBLHFDHFE(Action<ArraySegment<float>> HFJNADOBPEL)
		{
			return default(OOFHFENOMKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77A5390", Offset = "0x77A3D90", VA = "0x1877A5390")]
		private OOFHFENOMKN PELBLHFDHFE(int OCDAAEPIOAN, int HHEHDLCIJDI, int EKLCNDFMPFB, Action<ArraySegment<float>> HFJNADOBPEL)
		{
			return default(OOFHFENOMKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77A5310", Offset = "0x77A3D10", VA = "0x1877A5310", Slot = "8")]
		public void KBIJMHCDKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77A5780", Offset = "0x77A4180", VA = "0x1877A5780")]
		public JJDPJLALPDN(MMDevice EFOJMAFPEGN, bool NIGJLHPPDKA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JJDPJLALPDN> HAIDCBFNGPC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GGHJENNMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x77A4DC0", Offset = "0x77A37C0", VA = "0x1877A4DC0", Slot = "5")]
	public IReadOnlyList<OJCJBDJJEEC> DOANOMOCKFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77A50E0", Offset = "0x77A3AE0", VA = "0x1877A50E0")]
	public CPGDABNKCPJ()
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
