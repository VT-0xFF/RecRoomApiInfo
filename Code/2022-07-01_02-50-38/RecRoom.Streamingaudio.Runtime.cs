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
public interface FMLJBLIOKAH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AGEKMHFIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EPDGKMCOMDI> PEHIMMPMGJI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EPDGKMCOMDI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LEMKEAMGAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GBMBJCBFIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AALOBCCMBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LBCEBKHLCLB DFHHFACAFKH(Action<ArraySegment<float>> HNMFGPCGPOH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGNFIKILLCC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LBCEBKHLCLB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PNMJCBJLADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60DDA0", Offset = "0x60C5A0", VA = "0x18060DDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x855720", Offset = "0x853F20", VA = "0x180855720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ONHCIPNMCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C50", Offset = "0x9C0450", VA = "0x1809C1C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1C80", Offset = "0x9C0480", VA = "0x1809C1C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x124AA70", Offset = "0x1249270", VA = "0x18124AA70")]
	public LBCEBKHLCLB(int IADKOGMADMI, int APJGDBBIDJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAPBIDBONCA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FMLJBLIOKAH CEEEACBADNA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AGEKMHFIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x124A950", Offset = "0x1249150", VA = "0x18124A950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x124A9C0", Offset = "0x12491C0", VA = "0x18124A9C0")]
	static EAPBIDBONCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x124A860", Offset = "0x1249060", VA = "0x18124A860")]
	public static IReadOnlyList<EPDGKMCOMDI> PEHIMMPMGJI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NOMABLGJEAH : FMLJBLIOKAH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PMNGMDMMJFK : EPDGKMCOMDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ALDGLEIKOPG
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
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578040", VA = "0x180579840")]
			public ALDGLEIKOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x124A6E0", Offset = "0x1248EE0", VA = "0x18124A6E0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HGDMFCGOHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HHHDHKEIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ABJAEPALCJG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LEMKEAMGAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x124B100", Offset = "0x1249900", VA = "0x18124B100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GBMBJCBFIOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x73E020", Offset = "0x73C820", VA = "0x18073E020", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x73E070", Offset = "0x73C870", VA = "0x18073E070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AALOBCCMBGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8F95A0", Offset = "0x8F7DA0", VA = "0x1808F95A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x124AD90", Offset = "0x1249590", VA = "0x18124AD90", Slot = "7")]
		public LBCEBKHLCLB DFHHFACAFKH(Action<ArraySegment<float>> HNMFGPCGPOH)
		{
			return default(LBCEBKHLCLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x124ADC0", Offset = "0x12495C0", VA = "0x18124ADC0")]
		private LBCEBKHLCLB DFHHFACAFKH(int IADKOGMADMI, int GBEMJJDEJMD, int APJGDBBIDJH, Action<ArraySegment<float>> HNMFGPCGPOH)
		{
			return default(LBCEBKHLCLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x124B120", Offset = "0x1249920", VA = "0x18124B120", Slot = "8")]
		public void MGNFIKILLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x124B1A0", Offset = "0x12499A0", VA = "0x18124B1A0")]
		public PMNGMDMMJFK(MMDevice HGDMFCGOHJL, bool BBJHABNHOEM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PMNGMDMMJFK> IKNHMFGOCJE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AGEKMHFIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x5731D0", VA = "0x1805749D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x124AA80", Offset = "0x1249280", VA = "0x18124AA80", Slot = "5")]
	public IReadOnlyList<EPDGKMCOMDI> PEHIMMPMGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x124AD20", Offset = "0x1249520", VA = "0x18124AD20")]
	public NOMABLGJEAH()
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
