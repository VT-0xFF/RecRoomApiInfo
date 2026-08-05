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
public interface KBOJPELIFAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CKKPGPDJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MFKOAHBHNIH> HMOCPHDPACA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MFKOAHBHNIH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FEFBPCBFNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool AJIMDFDBELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HEODJMLMFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CGGEEHICMHJ LBOLEMGENGK(Action<ArraySegment<float>> KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEMEFBHNOOG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CGGEEHICMHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FANBKKHHPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9E3640", Offset = "0x9E1E40", VA = "0x1809E3640")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD1C690", Offset = "0xD1AE90", VA = "0x180D1C690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CBPOPLBKCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293ADC0", VA = "0x18293C5C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6292880", Offset = "0x6291080", VA = "0x186292880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9FCD0", Offset = "0x6F9E4D0", VA = "0x186F9FCD0")]
	public CGGEEHICMHJ(int BABMEOKPLPN, int MIPAMMPIFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IPOKMGJLPCF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KBOJPELIFAE ABHFKNDHMBI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool CKKPGPDJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x794AFD0", Offset = "0x79497D0", VA = "0x18794AFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x794B050", Offset = "0x7949850", VA = "0x18794B050")]
	static IPOKMGJLPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x794AEE0", Offset = "0x79496E0", VA = "0x18794AEE0")]
	public static IReadOnlyList<MFKOAHBHNIH> HMOCPHDPACA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IKJHDMHBCDH : KBOJPELIFAE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DOHKJLFLHEA : MFKOAHBHNIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OHPFEBMCLCP
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
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public OHPFEBMCLCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x794B140", Offset = "0x7949940", VA = "0x18794B140")]
			internal void BEPMKIDCFCI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GBFNOAEOEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FNACOJOGKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EHIGAKGOAJH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FEFBPCBFNHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x794A650", Offset = "0x7948E50", VA = "0x18794A650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AJIMDFDBELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA02A00", Offset = "0xA01200", VA = "0x180A02A00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA028C0", Offset = "0xA010C0", VA = "0x180A028C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HEODJMLMFPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99E800", Offset = "0x99D000", VA = "0x18099E800", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x794A6F0", Offset = "0x7948EF0", VA = "0x18794A6F0", Slot = "7")]
		public CGGEEHICMHJ LBOLEMGENGK(Action<ArraySegment<float>> KNMHMBJIFMM)
		{
			return default(CGGEEHICMHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x794A720", Offset = "0x7948F20", VA = "0x18794A720")]
		private CGGEEHICMHJ LBOLEMGENGK(int BABMEOKPLPN, int LBFKEIBGBGL, int MIPAMMPIFEI, Action<ArraySegment<float>> KNMHMBJIFMM)
		{
			return default(CGGEEHICMHJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x794A670", Offset = "0x7948E70", VA = "0x18794A670", Slot = "8")]
		public void GEMEFBHNOOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x794AAE0", Offset = "0x79492E0", VA = "0x18794AAE0")]
		public DOHKJLFLHEA(MMDevice GBFNOAEOEKP, bool EGIOEFFNJAP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DOHKJLFLHEA> JHBJIEGBFLI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool CKKPGPDJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D13B0", Offset = "0x8CFBB0", VA = "0x1808D13B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x794AB30", Offset = "0x7949330", VA = "0x18794AB30", Slot = "5")]
	public IReadOnlyList<MFKOAHBHNIH> HMOCPHDPACA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x794AE50", Offset = "0x7949650", VA = "0x18794AE50")]
	public IKJHDMHBCDH()
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
