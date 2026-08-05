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
public interface EHDLNBLPOJL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MCNKIKIEMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CBKGHODNHKH> CDFJABMMGOC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBKGHODNHKH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NACELFMAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PLKPOBHABBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MOKCDBPCIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DFIJFFHGKHF AMKLECFAECK(Action<ArraySegment<float>> GMDMDOLDPBH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDOBKKBGDMM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DFIJFFHGKHF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PNBLBLOFHNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71C060", Offset = "0x71AE60", VA = "0x18071C060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B49F0", Offset = "0x7B37F0", VA = "0x1807B49F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BJGFAKJHDKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AE40", VA = "0x18071C040")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x470D2B0", Offset = "0x470C0B0", VA = "0x18470D2B0")]
	public DFIJFFHGKHF(int AELJOCAAPFP, int NJJAGAEJJLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LLOBBDADNGD
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static EHDLNBLPOJL CIHBKDBIHCH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MCNKIKIEMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x470D6C0", Offset = "0x470C4C0", VA = "0x18470D6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x470D730", Offset = "0x470C530", VA = "0x18470D730")]
	static LLOBBDADNGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x470D5D0", Offset = "0x470C3D0", VA = "0x18470D5D0")]
	public static IReadOnlyList<CBKGHODNHKH> CDFJABMMGOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FPOGOIFKBIG : EHDLNBLPOJL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OJBMMJNMCGG : CBKGHODNHKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BLDGEBKKGEM
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
			[Cpp2IlInjected.Address(RVA = "0x4EBAB0", Offset = "0x4EA8B0", VA = "0x1804EBAB0")]
			public BLDGEBKKGEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x470D130", Offset = "0x470BF30", VA = "0x18470D130")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IJMHGKOGIAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LNKJFMFMBOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HOKANPOOFHN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NACELFMAGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x470DBD0", Offset = "0x470C9D0", VA = "0x18470DBD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PLKPOBHABBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5AE7A0", Offset = "0x5AD5A0", VA = "0x1805AE7A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x60B9E0", Offset = "0x60A7E0", VA = "0x18060B9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MOKCDBPCIGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A80E0", Offset = "0x6A6EE0", VA = "0x1806A80E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x470DB20", Offset = "0x470C920", VA = "0x18470DB20", Slot = "7")]
		public DFIJFFHGKHF AMKLECFAECK(Action<ArraySegment<float>> GMDMDOLDPBH)
		{
			return default(DFIJFFHGKHF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x470D7E0", Offset = "0x470C5E0", VA = "0x18470D7E0")]
		private DFIJFFHGKHF AMKLECFAECK(int AELJOCAAPFP, int AKNHIOGDHGC, int NJJAGAEJJLP, Action<ArraySegment<float>> GMDMDOLDPBH)
		{
			return default(DFIJFFHGKHF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x470DB50", Offset = "0x470C950", VA = "0x18470DB50", Slot = "8")]
		public void HDOBKKBGDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x470DBF0", Offset = "0x470C9F0", VA = "0x18470DBF0")]
		public OJBMMJNMCGG(MMDevice IJMHGKOGIAM, bool HJBAHJGCEDI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OJBMMJNMCGG> BPMIEPPGBCB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MCNKIKIEMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4E9FE0", Offset = "0x4E8DE0", VA = "0x1804E9FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x470D2C0", Offset = "0x470C0C0", VA = "0x18470D2C0", Slot = "5")]
	public IReadOnlyList<CBKGHODNHKH> CDFJABMMGOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x470D560", Offset = "0x470C360", VA = "0x18470D560")]
	public FPOGOIFKBIG()
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
