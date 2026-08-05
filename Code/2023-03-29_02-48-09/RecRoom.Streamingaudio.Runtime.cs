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
public interface OAEMDFBPIEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MAKAOENFBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DKNHLEJBJIO> LAEDBOCAEJO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DKNHLEJBJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KFEOLFOGHMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IOJOLAAGCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DPHMFBACLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GICLOFPGAHG EIDIMHAOMLF(Action<ArraySegment<float>> JDLJMIHPPKE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EBNFDCONOGF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GICLOFPGAHG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HEBMLJFKOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x73BCB0", Offset = "0x73AAB0", VA = "0x18073BCB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x73D530", Offset = "0x73C330", VA = "0x18073D530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ABLPPLDMDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x795660", Offset = "0x794460", VA = "0x180795660")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x795670", Offset = "0x794470", VA = "0x180795670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66357E0", Offset = "0x66345E0", VA = "0x1866357E0")]
	public GICLOFPGAHG(int IFIBOFBDBHD, int IJPAKOBNDOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ANHJJMINJEN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OAEMDFBPIEO PLFNKOGOLEK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MAKAOENFBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6635230", Offset = "0x6634030", VA = "0x186635230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66353B0", Offset = "0x66341B0", VA = "0x1866353B0")]
	static ANHJJMINJEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66352B0", Offset = "0x66340B0", VA = "0x1866352B0")]
	public static IReadOnlyList<DKNHLEJBJIO> LAEDBOCAEJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FJJJDKAJJJI : OAEMDFBPIEO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MLJDEPKJCAK : DKNHLEJBJIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JKMAEJLIGNK
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
			[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
			public JKMAEJLIGNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66357F0", Offset = "0x66345F0", VA = "0x1866357F0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NLCBBMHMNCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NKKILOBIIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ABPHJCDBGBK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KFEOLFOGHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6635DD0", Offset = "0x6634BD0", VA = "0x186635DD0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IOJOLAAGCIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x82D580", Offset = "0x82C380", VA = "0x18082D580", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x82D600", Offset = "0x82C400", VA = "0x18082D600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DPHMFBACLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83AE40", Offset = "0x839C40", VA = "0x18083AE40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6635DA0", Offset = "0x6634BA0", VA = "0x186635DA0", Slot = "7")]
		public GICLOFPGAHG EIDIMHAOMLF(Action<ArraySegment<float>> JDLJMIHPPKE)
		{
			return default(GICLOFPGAHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6635A00", Offset = "0x6634800", VA = "0x186635A00")]
		private GICLOFPGAHG EIDIMHAOMLF(int IFIBOFBDBHD, int IIJPCEBFOFB, int IJPAKOBNDOE, Action<ArraySegment<float>> JDLJMIHPPKE)
		{
			return default(GICLOFPGAHG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6635980", Offset = "0x6634780", VA = "0x186635980", Slot = "8")]
		public void EBNFDCONOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6635DF0", Offset = "0x6634BF0", VA = "0x186635DF0")]
		public MLJDEPKJCAK(MMDevice NLCBBMHMNCL, bool CHINEGNFIPC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MLJDEPKJCAK> NHOFLPFDJOH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MAKAOENFBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x70F850", Offset = "0x70E650", VA = "0x18070F850", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6635480", Offset = "0x6634280", VA = "0x186635480", Slot = "5")]
	public IReadOnlyList<DKNHLEJBJIO> LAEDBOCAEJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6635760", Offset = "0x6634560", VA = "0x186635760")]
	public FJJJDKAJJJI()
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
