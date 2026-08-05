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
public interface NDIDFOCNIGA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EDIOCFONNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NPFHOCHIPNK> KNGFANNNGFC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NPFHOCHIPNK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LCJHEDKOGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IGKEOLCDODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KAFBFGLNJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CEJHMOOBLIO PAFODEJAKOM(Action<ArraySegment<float>> GKAOJENLDLL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOKBOPPIGFI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CEJHMOOBLIO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HOGOKLNADDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73E0D0", Offset = "0x73CED0", VA = "0x18073E0D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC46420", Offset = "0xC45220", VA = "0x180C46420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJNNIHIJMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73E0B0", Offset = "0x73CEB0", VA = "0x18073E0B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC49E10", Offset = "0xC48C10", VA = "0x180C49E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90550", Offset = "0x5E8F350", VA = "0x185E90550")]
	public CEJHMOOBLIO(int BHOKLPHBGHB, int PFLFJPDPIBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ACIDNLMCKKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NDIDFOCNIGA MPCCHNGMGHB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EDIOCFONNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E90400", Offset = "0x5E8F200", VA = "0x185E90400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90480", Offset = "0x5E8F280", VA = "0x185E90480")]
	static ACIDNLMCKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E90300", Offset = "0x5E8F100", VA = "0x185E90300")]
	public static IReadOnlyList<NPFHOCHIPNK> KNGFANNNGFC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FGBNDEEAGCL : NDIDFOCNIGA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LDPDGLFKDLI : NPFHOCHIPNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class FDBDIHFEECL
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
			[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
			public FDBDIHFEECL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E90560", Offset = "0x5E8F360", VA = "0x185E90560")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HFEDAOBGPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MMLFFOKLFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JCKHPNEEADB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LCJHEDKOGHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5E90A50", Offset = "0x5E8F850", VA = "0x185E90A50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IGKEOLCDODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7CA100", Offset = "0x7C8F00", VA = "0x1807CA100", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6A05E0", Offset = "0x69F3E0", VA = "0x1806A05E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KAFBFGLNJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x75AB80", Offset = "0x759980", VA = "0x18075AB80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E90AF0", Offset = "0x5E8F8F0", VA = "0x185E90AF0", Slot = "7")]
		public CEJHMOOBLIO PAFODEJAKOM(Action<ArraySegment<float>> GKAOJENLDLL)
		{
			return default(CEJHMOOBLIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E90B20", Offset = "0x5E8F920", VA = "0x185E90B20")]
		private CEJHMOOBLIO PAFODEJAKOM(int BHOKLPHBGHB, int OAMKHBKCHHA, int PFLFJPDPIBH, Action<ArraySegment<float>> GKAOJENLDLL)
		{
			return default(CEJHMOOBLIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E90A70", Offset = "0x5E8F870", VA = "0x185E90A70", Slot = "8")]
		public void MOKBOPPIGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E90EC0", Offset = "0x5E8FCC0", VA = "0x185E90EC0")]
		public LDPDGLFKDLI(MMDevice HFEDAOBGPDF, bool AIIBHLMBNFP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<LDPDGLFKDLI> HDICMJGBIOL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EDIOCFONNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6619E0", Offset = "0x6607E0", VA = "0x1806619E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E906F0", Offset = "0x5E8F4F0", VA = "0x185E906F0", Slot = "5")]
	public IReadOnlyList<NPFHOCHIPNK> KNGFANNNGFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E909D0", Offset = "0x5E8F7D0", VA = "0x185E909D0")]
	public FGBNDEEAGCL()
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
