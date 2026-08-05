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
public interface MEJIEFEEAJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KJCOEAMBIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PILHEIEFEPC> NMKFNHAHKND();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PILHEIEFEPC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AIHDEPPKDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GAKDLMEOPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JBMCDDFNMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FFAHOMKGLLO MGCLBEEAEEH(Action<ArraySegment<float>> LAOAAOBGDLL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLNPELELBCG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FFAHOMKGLLO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KGIDAAJIGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xDB2450", Offset = "0xDB0A50", VA = "0x180DB2450")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MKDHOMNICII
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x30A0340", Offset = "0x309E940", VA = "0x1830A0340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x855E100", Offset = "0x855C700", VA = "0x18855E100")]
	public FFAHOMKGLLO(int KBIICOGOBJL, int NOJMAMBJJKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NDPOOICDIOB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MEJIEFEEAJE EPANJENKOEM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KJCOEAMBIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x90915A0", Offset = "0x908FBA0", VA = "0x1890915A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9091710", Offset = "0x908FD10", VA = "0x189091710")]
	static NDPOOICDIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x9091620", Offset = "0x908FC20", VA = "0x189091620")]
	public static IReadOnlyList<PILHEIEFEPC> NMKFNHAHKND()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MHAOMFKBCGN : MEJIEFEEAJE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LGOGHCHAAKK : PILHEIEFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ACOCDGNKHIN
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
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ACOCDGNKHIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9090B90", Offset = "0x908F190", VA = "0x189090B90")]
			internal void ICAOBEOJNKN(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OLIHLGBEJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JHKPKNJGHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HPKLFHCANFP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AIHDEPPKDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9091180", Offset = "0x908F780", VA = "0x189091180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GAKDLMEOPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC18890", Offset = "0xC16E90", VA = "0x180C18890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JBMCDDFNMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF36FA0", Offset = "0xF355A0", VA = "0x180F36FA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90910D0", Offset = "0x908F6D0", VA = "0x1890910D0", Slot = "7")]
		public FFAHOMKGLLO MGCLBEEAEEH(Action<ArraySegment<float>> LAOAAOBGDLL)
		{
			return default(FFAHOMKGLLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9090D10", Offset = "0x908F310", VA = "0x189090D10")]
		private FFAHOMKGLLO MGCLBEEAEEH(int KBIICOGOBJL, int BBLIPKCCKPI, int NOJMAMBJJKK, Action<ArraySegment<float>> LAOAAOBGDLL)
		{
			return default(FFAHOMKGLLO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9091100", Offset = "0x908F700", VA = "0x189091100", Slot = "8")]
		public void MLNPELELBCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90911A0", Offset = "0x908F7A0", VA = "0x1890911A0")]
		public LGOGHCHAAKK(MMDevice OLIHLGBEJKI, bool KAKKPBKEMHD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<LGOGHCHAAKK> CCIJLIJAPEP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KJCOEAMBIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x90911F0", Offset = "0x908F7F0", VA = "0x1890911F0", Slot = "5")]
	public IReadOnlyList<PILHEIEFEPC> NMKFNHAHKND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x9091510", Offset = "0x908FB10", VA = "0x189091510")]
	public MHAOMFKBCGN()
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
