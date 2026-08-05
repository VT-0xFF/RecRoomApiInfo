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
		[Cpp2IlInjected.Address(RVA = "0x708E20", Offset = "0x707E20", VA = "0x180708E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x708D90", Offset = "0x707D90", VA = "0x180708D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJNNIHIJMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEAA480", Offset = "0xEA9480", VA = "0x180EAA480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E92450", Offset = "0x5E91450", VA = "0x185E92450")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E92300", Offset = "0x5E91300", VA = "0x185E92300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E92380", Offset = "0x5E91380", VA = "0x185E92380")]
	static ACIDNLMCKKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E92200", Offset = "0x5E91200", VA = "0x185E92200")]
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
			[Cpp2IlInjected.Address(RVA = "0x658B30", Offset = "0x657B30", VA = "0x180658B30")]
			public FDBDIHFEECL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E92460", Offset = "0x5E91460", VA = "0x185E92460")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E92950", Offset = "0x5E91950", VA = "0x185E92950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IGKEOLCDODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761B40", VA = "0x180762B40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x711170", Offset = "0x710170", VA = "0x180711170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KAFBFGLNJEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x698C60", Offset = "0x697C60", VA = "0x180698C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E929F0", Offset = "0x5E919F0", VA = "0x185E929F0", Slot = "7")]
		public CEJHMOOBLIO PAFODEJAKOM(Action<ArraySegment<float>> GKAOJENLDLL)
		{
			return default(CEJHMOOBLIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E92A20", Offset = "0x5E91A20", VA = "0x185E92A20")]
		private CEJHMOOBLIO PAFODEJAKOM(int BHOKLPHBGHB, int OAMKHBKCHHA, int PFLFJPDPIBH, Action<ArraySegment<float>> GKAOJENLDLL)
		{
			return default(CEJHMOOBLIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E92970", Offset = "0x5E91970", VA = "0x185E92970", Slot = "8")]
		public void MOKBOPPIGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E92DC0", Offset = "0x5E91DC0", VA = "0x185E92DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x678020", Offset = "0x677020", VA = "0x180678020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E925F0", Offset = "0x5E915F0", VA = "0x185E925F0", Slot = "5")]
	public IReadOnlyList<NPFHOCHIPNK> KNGFANNNGFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E928D0", Offset = "0x5E918D0", VA = "0x185E928D0")]
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
