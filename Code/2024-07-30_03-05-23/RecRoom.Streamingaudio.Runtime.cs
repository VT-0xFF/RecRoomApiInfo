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
public interface CFHEAOMLPFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PKKKAMFPJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JDOPGAHBPAK> GELHBOMAEKK();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JDOPGAHBPAK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MFMHHDGDGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GLKOAJLFJLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OJNANIFGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGNLMEEEPED PFPLLGHKJBP(Action<ArraySegment<float>> JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NEICDFJFLHM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FGNLMEEEPED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MCPGMKJNAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAAF730", Offset = "0xAADD30", VA = "0x180AAF730")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IJHFIBJMEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x259FD50", Offset = "0x259E350", VA = "0x18259FD50")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DD2910", Offset = "0x5DD0F10", VA = "0x185DD2910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7368460", Offset = "0x7366A60", VA = "0x187368460")]
	public FGNLMEEEPED(int MBJMEEAFAJG, int FCOGKGJCAJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JNAEAAMGDJN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CFHEAOMLPFP CPDLPLKCBAE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PKKKAMFPJHB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7368950", Offset = "0x7366F50", VA = "0x187368950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7368AC0", Offset = "0x73670C0", VA = "0x187368AC0")]
	static JNAEAAMGDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x73689D0", Offset = "0x7366FD0", VA = "0x1873689D0")]
	public static IReadOnlyList<JDOPGAHBPAK> GELHBOMAEKK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MEPKMEODNDO : CFHEAOMLPFP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JMLMKOBPGOC : JDOPGAHBPAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PNMEOIIAACI
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
			[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
			public PNMEOIIAACI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7368F60", Offset = "0x7367560", VA = "0x187368F60")]
			internal void MEGDKHGNCHJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice GANAJJJOEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OJBGOEAGHJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ALODDDELMOI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MFMHHDGDGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7368470", Offset = "0x7366A70", VA = "0x187368470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GLKOAJLFJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA5760", Offset = "0xAA3D60", VA = "0x180AA5760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB9CB80", Offset = "0xB9B180", VA = "0x180B9CB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OJNANIFGJDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEF3E50", Offset = "0xEF2450", VA = "0x180EF3E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x73688D0", Offset = "0x7366ED0", VA = "0x1873688D0", Slot = "7")]
		public FGNLMEEEPED PFPLLGHKJBP(Action<ArraySegment<float>> JMMEJHGHOEF)
		{
			return default(FGNLMEEEPED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7368510", Offset = "0x7366B10", VA = "0x187368510")]
		private FGNLMEEEPED PFPLLGHKJBP(int MBJMEEAFAJG, int GPHINBHEIFI, int FCOGKGJCAJI, Action<ArraySegment<float>> JMMEJHGHOEF)
		{
			return default(FGNLMEEEPED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7368490", Offset = "0x7366A90", VA = "0x187368490", Slot = "8")]
		public void NEICDFJFLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7368900", Offset = "0x7366F00", VA = "0x187368900")]
		public JMLMKOBPGOC(MMDevice GANAJJJOEFF, bool GCNMLLEKKKP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JMLMKOBPGOC> EOBLLHNAKLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PKKKAMFPJHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x881710", Offset = "0x87FD10", VA = "0x180881710", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7368BB0", Offset = "0x73671B0", VA = "0x187368BB0", Slot = "5")]
	public IReadOnlyList<JDOPGAHBPAK> GELHBOMAEKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7368ED0", Offset = "0x73674D0", VA = "0x187368ED0")]
	public MEPKMEODNDO()
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
