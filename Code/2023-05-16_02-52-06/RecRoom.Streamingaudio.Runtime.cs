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
public interface MPMAMNGKEDH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ONGPKDECJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ECDJLPBFDJF> PNOFOFFCAEH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ECDJLPBFDJF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BAPPBPLIODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MANAJJKENOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BFOAHGLFHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIJAIOLOJIP ILBBMGEGFNM(Action<ArraySegment<float>> FNIOCOFMFAB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKGJOFPJNFB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NIJAIOLOJIP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NCAHFNACOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E0", Offset = "0x7D42E0", VA = "0x1807D54E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80A490", Offset = "0x809290", VA = "0x18080A490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GCMGEDJNLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90B640", Offset = "0x90A440", VA = "0x18090B640")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xF02C00", Offset = "0xF01A00", VA = "0x180F02C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B29DC0", Offset = "0x6B28BC0", VA = "0x186B29DC0")]
	public NIJAIOLOJIP(int GMOOJOCMFGH, int BCPFIBNBBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KEFGGBBODDB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MPMAMNGKEDH NKFBAGFDEEO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool ONGPKDECJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B29810", Offset = "0x6B28610", VA = "0x186B29810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B29990", Offset = "0x6B28790", VA = "0x186B29990")]
	static KEFGGBBODDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B29890", Offset = "0x6B28690", VA = "0x186B29890")]
	public static IReadOnlyList<ECDJLPBFDJF> PNOFOFFCAEH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LGOGIJMHMMN : MPMAMNGKEDH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GDKJGMODGOH : ECDJLPBFDJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DPMCNKAJLFL
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
			[Cpp2IlInjected.Address(RVA = "0x741B30", Offset = "0x740930", VA = "0x180741B30")]
			public DPMCNKAJLFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6B291C0", Offset = "0x6B27FC0", VA = "0x186B291C0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EJCJAFAPPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KNLKEKNAHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IHILGHIAKJB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BAPPBPLIODL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6B29350", Offset = "0x6B28150", VA = "0x186B29350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MANAJJKENOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x849670", Offset = "0x848470", VA = "0x180849670", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x812860", Offset = "0x811660", VA = "0x180812860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BFOAHGLFHDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x782E40", Offset = "0x781C40", VA = "0x180782E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B29710", Offset = "0x6B28510", VA = "0x186B29710", Slot = "7")]
		public NIJAIOLOJIP ILBBMGEGFNM(Action<ArraySegment<float>> FNIOCOFMFAB)
		{
			return default(NIJAIOLOJIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B29370", Offset = "0x6B28170", VA = "0x186B29370")]
		private NIJAIOLOJIP ILBBMGEGFNM(int GMOOJOCMFGH, int BGHMAHLLPGD, int BCPFIBNBBDB, Action<ArraySegment<float>> FNIOCOFMFAB)
		{
			return default(NIJAIOLOJIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6B29740", Offset = "0x6B28540", VA = "0x186B29740", Slot = "8")]
		public void LKGJOFPJNFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B297C0", Offset = "0x6B285C0", VA = "0x186B297C0")]
		public GDKJGMODGOH(MMDevice EJCJAFAPPGF, bool PCLDLPLIBPB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GDKJGMODGOH> DNELJKHKDHG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ONGPKDECJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7621B0", Offset = "0x760FB0", VA = "0x1807621B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B29A60", Offset = "0x6B28860", VA = "0x186B29A60", Slot = "5")]
	public IReadOnlyList<ECDJLPBFDJF> PNOFOFFCAEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B29D40", Offset = "0x6B28B40", VA = "0x186B29D40")]
	public LGOGIJMHMMN()
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
