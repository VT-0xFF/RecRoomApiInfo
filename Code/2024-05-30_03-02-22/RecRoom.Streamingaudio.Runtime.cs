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
public interface OEJLBCGKIND
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LGHIJFJJJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MAIGNAHOOLG> PKPHBEMNILG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MAIGNAHOOLG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BEDLHJMHALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool NAMIDCEIELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PMPAMJGELOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPDEPAMHNED BBBLBHDGBPC(Action<ArraySegment<float>> GPGHCLCHGND);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPFOAMDJONJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CPDEPAMHNED
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JHLBAECHFHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x877370", Offset = "0x876570", VA = "0x180877370")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9CBB80", Offset = "0x9CAD80", VA = "0x1809CBB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KPPAFNBDDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24131E0", Offset = "0x24123E0", VA = "0x1824131E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5819400", Offset = "0x5818600", VA = "0x185819400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2C80", Offset = "0x6CE1E80", VA = "0x186CE2C80")]
	public CPDEPAMHNED(int JCIEECPCKOG, int MOHAPIFAEGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AHLIFBIFONG
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OEJLBCGKIND IHIAHAELDLM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LGHIJFJJJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE2500", Offset = "0x6CE1700", VA = "0x186CE2500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2670", Offset = "0x6CE1870", VA = "0x186CE2670")]
	static AHLIFBIFONG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2580", Offset = "0x6CE1780", VA = "0x186CE2580")]
	public static IReadOnlyList<MAIGNAHOOLG> PKPHBEMNILG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class APAMOMNOAME : OEJLBCGKIND
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NHGJCJIHAKK : MAIGNAHOOLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BFEMEFAJONI
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
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public BFEMEFAJONI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6CE2B00", Offset = "0x6CE1D00", VA = "0x186CE2B00")]
			internal void NMLIKAPKNBC(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DNFPBLBNBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ODGONGNBIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HIMGLHFHIOC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BEDLHJMHALJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6CE3100", Offset = "0x6CE2300", VA = "0x186CE3100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NAMIDCEIELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9B6690", Offset = "0x9B5890", VA = "0x1809B6690", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA8C3F0", Offset = "0xA8B5F0", VA = "0x180A8C3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PMPAMJGELOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xDDFB70", Offset = "0xDDED70", VA = "0x180DDFB70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CE2C90", Offset = "0x6CE1E90", VA = "0x186CE2C90", Slot = "7")]
		public CPDEPAMHNED BBBLBHDGBPC(Action<ArraySegment<float>> GPGHCLCHGND)
		{
			return default(CPDEPAMHNED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6CE2CC0", Offset = "0x6CE1EC0", VA = "0x186CE2CC0")]
		private CPDEPAMHNED BBBLBHDGBPC(int JCIEECPCKOG, int AGCHHOOPDFN, int MOHAPIFAEGD, Action<ArraySegment<float>> GPGHCLCHGND)
		{
			return default(CPDEPAMHNED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CE3080", Offset = "0x6CE2280", VA = "0x186CE3080", Slot = "8")]
		public void BPFOAMDJONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CE3120", Offset = "0x6CE2320", VA = "0x186CE3120")]
		public NHGJCJIHAKK(MMDevice DNFPBLBNBLN, bool BADDKICCKMN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NHGJCJIHAKK> EKIABOJIEAO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LGHIJFJJJDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E37C0", Offset = "0x7E29C0", VA = "0x1807E37C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2760", Offset = "0x6CE1960", VA = "0x186CE2760", Slot = "5")]
	public IReadOnlyList<MAIGNAHOOLG> PKPHBEMNILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2A70", Offset = "0x6CE1C70", VA = "0x186CE2A70")]
	public APAMOMNOAME()
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
