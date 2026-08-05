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
public interface IAOABODKKLA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EEKKILMKDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LJPHFPEDMPH> PAELKNCIABC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJPHFPEDMPH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ADEJLEBKGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FJJNGJNGBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HONIAFKGGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PLMAANPHDAF FFFPHHIFCAP(Action<ArraySegment<float>> LOGLEICCEGM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ALGCHGAPNCN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PLMAANPHDAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PKFHFMDMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B1820", Offset = "0x9B0C20", VA = "0x1809B1820")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1123940", Offset = "0x1122D40", VA = "0x181123940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LPMNILKAMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BEE380", Offset = "0x2BED780", VA = "0x182BEE380")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACF10", Offset = "0x68AC310", VA = "0x1868ACF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7642DA0", Offset = "0x76421A0", VA = "0x187642DA0")]
	public PLMAANPHDAF(int NJAAPLMAKND, int FKGKAFNMPMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HABHGMBNNDD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IAOABODKKLA ABBEFNLLLMK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EEKKILMKDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80677F0", Offset = "0x8066BF0", VA = "0x1880677F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8067950", Offset = "0x8066D50", VA = "0x188067950")]
	static HABHGMBNNDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8067860", Offset = "0x8066C60", VA = "0x188067860")]
	public static IReadOnlyList<LJPHFPEDMPH> PAELKNCIABC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GOPAMCEICJI : IAOABODKKLA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NKIOGBPHPDE : LJPHFPEDMPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GIMFOMGBCMI
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
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public GIMFOMGBCMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x80672C0", Offset = "0x80666C0", VA = "0x1880672C0")]
			internal void FFMGOCGGFDL(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PJFCGPLMAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KKKFCFMLBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LBFEFBHJHDA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ADEJLEBKGFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8067EB0", Offset = "0x80672B0", VA = "0x188067EB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FJJNGJNGBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCEB360", Offset = "0xCEA760", VA = "0x180CEB360", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCEB250", Offset = "0xCEA650", VA = "0x180CEB250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HONIAFKGGPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCA6ED0", Offset = "0xCA62D0", VA = "0x180CA6ED0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8067E80", Offset = "0x8067280", VA = "0x188067E80", Slot = "7")]
		public PLMAANPHDAF FFFPHHIFCAP(Action<ArraySegment<float>> LOGLEICCEGM)
		{
			return default(PLMAANPHDAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8067AC0", Offset = "0x8066EC0", VA = "0x188067AC0")]
		private PLMAANPHDAF FFFPHHIFCAP(int NJAAPLMAKND, int GJJGOFIIGHJ, int FKGKAFNMPMP, Action<ArraySegment<float>> LOGLEICCEGM)
		{
			return default(PLMAANPHDAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8067A40", Offset = "0x8066E40", VA = "0x188067A40", Slot = "8")]
		public void ALGCHGAPNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8067ED0", Offset = "0x80672D0", VA = "0x188067ED0")]
		public NKIOGBPHPDE(MMDevice PJFCGPLMAAO, bool LOJNADOJGKO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NKIOGBPHPDE> DLDCIJJDHGE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EEKKILMKDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8067440", Offset = "0x8066840", VA = "0x188067440", Slot = "5")]
	public IReadOnlyList<LJPHFPEDMPH> PAELKNCIABC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8067760", Offset = "0x8066B60", VA = "0x188067760")]
	public GOPAMCEICJI()
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
