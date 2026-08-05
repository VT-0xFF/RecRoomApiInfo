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
public interface ADKBKKDFLAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HMIKFOIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PLDLNIOPNAJ> COKIBPEOLPB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PLDLNIOPNAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OBGKIJGMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JMJDOCAGFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BKHJOBIAHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PIJDODLFAPG BEBBDKJFHEC(Action<ArraySegment<float>> DBNMPCEBPKD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NICCCAIDAEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PIJDODLFAPG
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IJCEGDJEIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x784510", Offset = "0x783110", VA = "0x180784510")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81CE80", Offset = "0x81BA80", VA = "0x18081CE80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MEGCBNOEFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7844F0", Offset = "0x7830F0", VA = "0x1807844F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6720", Offset = "0x7F5320", VA = "0x1807F6720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E3B0A0", Offset = "0x4E39CA0", VA = "0x184E3B0A0")]
	public PIJDODLFAPG(int EDLOIDKDILP, int LDJGNAHHIIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NKAFFNOOCEN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ADKBKKDFLAF CMDOEBOLICG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HMIKFOIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AF80", Offset = "0x4E39B80", VA = "0x184E3AF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AFF0", Offset = "0x4E39BF0", VA = "0x184E3AFF0")]
	static NKAFFNOOCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4E3AE90", Offset = "0x4E39A90", VA = "0x184E3AE90")]
	public static IReadOnlyList<PLDLNIOPNAJ> COKIBPEOLPB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HFPKHKJEACE : ADKBKKDFLAF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JEDEBCIDLAG : PLDLNIOPNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IKIKHPDFLMJ
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
			[Cpp2IlInjected.Address(RVA = "0x55EAB0", Offset = "0x55D6B0", VA = "0x18055EAB0")]
			public IKIKHPDFLMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4E3A8B0", Offset = "0x4E394B0", VA = "0x184E3A8B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice FAPAMMABDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NJNPGLFBFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MLLMBDCAKOL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OBGKIJGMNHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4E3AA30", Offset = "0x4E39630", VA = "0x184E3AA30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JMJDOCAGFMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5DD990", Offset = "0x5DC590", VA = "0x1805DD990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6CECC0", Offset = "0x6CD8C0", VA = "0x1806CECC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKHJOBIAHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x756EA0", Offset = "0x755AA0", VA = "0x180756EA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AD90", Offset = "0x4E39990", VA = "0x184E3AD90", Slot = "7")]
		public PIJDODLFAPG BEBBDKJFHEC(Action<ArraySegment<float>> DBNMPCEBPKD)
		{
			return default(PIJDODLFAPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AA50", Offset = "0x4E39650", VA = "0x184E3AA50")]
		private PIJDODLFAPG BEBBDKJFHEC(int EDLOIDKDILP, int NJAMKNDNGBF, int LDJGNAHHIIO, Action<ArraySegment<float>> DBNMPCEBPKD)
		{
			return default(PIJDODLFAPG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E3ADC0", Offset = "0x4E399C0", VA = "0x184E3ADC0", Slot = "8")]
		public void NICCCAIDAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E3AE40", Offset = "0x4E39A40", VA = "0x184E3AE40")]
		public JEDEBCIDLAG(MMDevice FAPAMMABDEI, bool KCFPIKMKMBE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JEDEBCIDLAG> CLCNECDLJKB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HMIKFOIDFHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x55CFE0", Offset = "0x55BBE0", VA = "0x18055CFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A5A0", Offset = "0x4E391A0", VA = "0x184E3A5A0", Slot = "5")]
	public IReadOnlyList<PLDLNIOPNAJ> COKIBPEOLPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4E3A840", Offset = "0x4E39440", VA = "0x184E3A840")]
	public HFPKHKJEACE()
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
