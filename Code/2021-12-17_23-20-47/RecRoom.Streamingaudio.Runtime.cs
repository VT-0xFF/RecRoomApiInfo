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
public interface MHFMPAAOJOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GJPFBPFKHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HGAONAGKLPG> DFHALHMFCAB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HGAONAGKLPG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NANEIAOKKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DBAOHDNGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LOAIPHANANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANFANAELFBF OIBOKKHMKFN(Action<ArraySegment<float>> HOOMNAEGALB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBJLNCGFKFE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ANFANAELFBF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LHMDKDKBJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x702D40", Offset = "0x701940", VA = "0x180702D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7634E0", Offset = "0x7620E0", VA = "0x1807634E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PAPPPHMDLFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x702D20", Offset = "0x701920", VA = "0x180702D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E6E930", Offset = "0x1E6D530", VA = "0x181E6E930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x43EEE30", Offset = "0x43EDA30", VA = "0x1843EEE30")]
	public ANFANAELFBF(int JIBEKLFPAHP, int FIKOGCHOFAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MKJNOMKOECN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MHFMPAAOJOJ PPKKEECELFO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GJPFBPFKHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x43EEFC0", Offset = "0x43EDBC0", VA = "0x1843EEFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43EF120", Offset = "0x43EDD20", VA = "0x1843EF120")]
	static MKJNOMKOECN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43EF030", Offset = "0x43EDC30", VA = "0x1843EF030")]
	public static IReadOnlyList<HGAONAGKLPG> DFHALHMFCAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MMOLMGIICPL : MHFMPAAOJOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class AGBLKKAFEBG : HGAONAGKLPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LFIECCPAOAA
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
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C15D0", VA = "0x1804C29D0")]
			public LFIECCPAOAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x43EEE40", Offset = "0x43EDA40", VA = "0x1843EEE40")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AKBEGOBACDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EHECPANJFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BCENHNMDPGJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NANEIAOKKPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43EEAC0", Offset = "0x43ED6C0", VA = "0x1843EEAC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DBAOHDNGOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x561E90", Offset = "0x560A90", VA = "0x180561E90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6A70C0", Offset = "0x6A5CC0", VA = "0x1806A70C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LOAIPHANANN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x676C10", VA = "0x180678010", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43EEDC0", Offset = "0x43ED9C0", VA = "0x1843EEDC0", Slot = "7")]
		public ANFANAELFBF OIBOKKHMKFN(Action<ArraySegment<float>> HOOMNAEGALB)
		{
			return default(ANFANAELFBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43EEAE0", Offset = "0x43ED6E0", VA = "0x1843EEAE0")]
		private ANFANAELFBF OIBOKKHMKFN(int JIBEKLFPAHP, int FKKJOFHJNNJ, int FIKOGCHOFAD, Action<ArraySegment<float>> HOOMNAEGALB)
		{
			return default(ANFANAELFBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43EEA60", Offset = "0x43ED660", VA = "0x1843EEA60", Slot = "8")]
		public void CBJLNCGFKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43EEDF0", Offset = "0x43ED9F0", VA = "0x1843EEDF0")]
		public AGBLKKAFEBG(MMDevice AKBEGOBACDK, bool ILABLCCKIHP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<AGBLKKAFEBG> FNJKGBEOHHL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GJPFBPFKHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4C0F60", Offset = "0x4BFB60", VA = "0x1804C0F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43EF1C0", Offset = "0x43EDDC0", VA = "0x1843EF1C0", Slot = "5")]
	public IReadOnlyList<HGAONAGKLPG> DFHALHMFCAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43EF460", Offset = "0x43EE060", VA = "0x1843EF460")]
	public MMOLMGIICPL()
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
