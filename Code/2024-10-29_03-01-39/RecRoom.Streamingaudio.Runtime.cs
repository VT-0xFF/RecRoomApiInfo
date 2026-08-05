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
public interface CHHFBEBLGID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IFDJPFECKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CDBCAEKKJJO> AKDKOFAPHNH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDBCAEKKJJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NJGIKIMFGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IDPFKMNBNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NCKJFFKLDNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NPEFFAPGJHN HHCLGKBOAAD(Action<ArraySegment<float>> BLNJHEMNIGB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBNNBNNACMH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NPEFFAPGJHN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FIIALHHJHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1E8F0", Offset = "0xA1D8F0", VA = "0x180A1E8F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD342A0", Offset = "0xD332A0", VA = "0x180D342A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HBOFKJHPOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28BDA20", Offset = "0x28BCA20", VA = "0x1828BDA20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x625B930", Offset = "0x625A930", VA = "0x18625B930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF9950", Offset = "0x6EF8950", VA = "0x186EF9950")]
	public NPEFFAPGJHN(int LCHGIBIAMJN, int BLDAMBEMEFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KEMINNFBNAG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CHHFBEBLGID ACMCOMOEFKD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IFDJPFECKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7842460", Offset = "0x7841460", VA = "0x187842460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x78424D0", Offset = "0x78414D0", VA = "0x1878424D0")]
	static KEMINNFBNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7842370", Offset = "0x7841370", VA = "0x187842370")]
	public static IReadOnlyList<CDBCAEKKJJO> AKDKOFAPHNH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ANGMJDFNHHM : CHHFBEBLGID
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class EDNLPHEAOIK : CDBCAEKKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GNKIADPMOPJ
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
			[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
			public GNKIADPMOPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x78421F0", Offset = "0x78411F0", VA = "0x1878421F0")]
			internal void MKCGPEOILOO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OJEPJAKFNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MONKPJMBCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JAHFNHKGKKB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NJGIKIMFGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7842180", Offset = "0x7841180", VA = "0x187842180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IDPFKMNBNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA39CA0", Offset = "0xA38CA0", VA = "0x180A39CA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA39BA0", Offset = "0xA38BA0", VA = "0x180A39BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NCKJFFKLDNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9EA3E0", Offset = "0x9E93E0", VA = "0x1809EA3E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7842150", Offset = "0x7841150", VA = "0x187842150", Slot = "7")]
		public NPEFFAPGJHN HHCLGKBOAAD(Action<ArraySegment<float>> BLNJHEMNIGB)
		{
			return default(NPEFFAPGJHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7841D90", Offset = "0x7840D90", VA = "0x187841D90")]
		private NPEFFAPGJHN HHCLGKBOAAD(int LCHGIBIAMJN, int HMCPIALOHNJ, int BLDAMBEMEFN, Action<ArraySegment<float>> BLNJHEMNIGB)
		{
			return default(NPEFFAPGJHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7841D10", Offset = "0x7840D10", VA = "0x187841D10", Slot = "8")]
		public void EBNNBNNACMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78421A0", Offset = "0x78411A0", VA = "0x1878421A0")]
		public EDNLPHEAOIK(MMDevice OJEPJAKFNHH, bool NPOHBGJDKNH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<EDNLPHEAOIK> IACFHODEJOO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IFDJPFECKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D05E0", Offset = "0x8CF5E0", VA = "0x1808D05E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7841960", Offset = "0x7840960", VA = "0x187841960", Slot = "5")]
	public IReadOnlyList<CDBCAEKKJJO> AKDKOFAPHNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7841C80", Offset = "0x7840C80", VA = "0x187841C80")]
	public ANGMJDFNHHM()
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
