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
public interface LFOJCAKMMEM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool INPKLAIKLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JDHCOMIABOA> HEHONJNAPHJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JDHCOMIABOA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NBMOENGHIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ICNNGHEEHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GBNKFMIGCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DKDCCHOFGIM NHCMDAIPJEM(Action<ArraySegment<float>> MKEOIOPNPIL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CCCMGMHAHKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DKDCCHOFGIM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AKJEFGENKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8986C0", Offset = "0x8970C0", VA = "0x1808986C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8986D0", Offset = "0x8970D0", VA = "0x1808986D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KIKHEFKGOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x215A030", Offset = "0x2158A30", VA = "0x18215A030")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x545DDD0", Offset = "0x545C7D0", VA = "0x18545DDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x670E280", Offset = "0x670CC80", VA = "0x18670E280")]
	public DKDCCHOFGIM(int LJJABMJICLO, int FFKIGNEJJJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OMEMBDOCNPG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LFOJCAKMMEM GPBFBAGNPML;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool INPKLAIKLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x670E8B0", Offset = "0x670D2B0", VA = "0x18670E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x670E930", Offset = "0x670D330", VA = "0x18670E930")]
	static OMEMBDOCNPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x670E7C0", Offset = "0x670D1C0", VA = "0x18670E7C0")]
	public static IReadOnlyList<JDHCOMIABOA> HEHONJNAPHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EHGBCBAJNLL : LFOJCAKMMEM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PONFCNMGBON : JDHCOMIABOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NJLCLFGAIDB
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
			[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
			public NJLCLFGAIDB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x670E640", Offset = "0x670D040", VA = "0x18670E640")]
			internal void KIIHIBJAKMP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HODHBLIDHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture AEGPEEIHCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BFBDINNCENM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NBMOENGHIIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x670EA20", Offset = "0x670D420", VA = "0x18670EA20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ICNNGHEEHCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87FD70", Offset = "0x87E770", VA = "0x18087FD70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x963850", Offset = "0x962250", VA = "0x180963850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GBNKFMIGCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC6EA30", Offset = "0xC6D430", VA = "0x180C6EA30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x670EE80", Offset = "0x670D880", VA = "0x18670EE80", Slot = "7")]
		public DKDCCHOFGIM NHCMDAIPJEM(Action<ArraySegment<float>> MKEOIOPNPIL)
		{
			return default(DKDCCHOFGIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x670EAC0", Offset = "0x670D4C0", VA = "0x18670EAC0")]
		private DKDCCHOFGIM NHCMDAIPJEM(int LJJABMJICLO, int JPBMPLMKLEB, int FFKIGNEJJJI, Action<ArraySegment<float>> MKEOIOPNPIL)
		{
			return default(DKDCCHOFGIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x670EA40", Offset = "0x670D440", VA = "0x18670EA40", Slot = "8")]
		public void CCCMGMHAHKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x670EEB0", Offset = "0x670D8B0", VA = "0x18670EEB0")]
		public PONFCNMGBON(MMDevice HODHBLIDHIC, bool GMEEAMKDOMC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PONFCNMGBON> PFJGALADBMN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool INPKLAIKLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x670E290", Offset = "0x670CC90", VA = "0x18670E290", Slot = "5")]
	public IReadOnlyList<JDHCOMIABOA> HEHONJNAPHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x670E5B0", Offset = "0x670CFB0", VA = "0x18670E5B0")]
	public EHGBCBAJNLL()
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
