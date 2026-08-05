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
public interface NCIJHILAJIL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GFADCEIHOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KNGGJOLCIAP> EBJMKEPNBDI();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KNGGJOLCIAP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DGJFAOEKPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JMNOIDFONLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IKKIDJCKFCM OJDOAJAAAIH(Action<ArraySegment<float>> BNOBGIHHJGL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIAIGIFIMDM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IKKIDJCKFCM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JNPNKJHNDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PHCFKDFHDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x306D380", Offset = "0x306B980", VA = "0x18306D380")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7175C10", Offset = "0x7174210", VA = "0x187175C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x800D6B0", Offset = "0x800BCB0", VA = "0x18800D6B0")]
	public IKKIDJCKFCM(int BLINAAHKHFN, int ADCCACNEHOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ILJGLLBOEMA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NCIJHILAJIL COCPPMIKKFC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GFADCEIHOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B02470", Offset = "0x8B00A70", VA = "0x188B02470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B024F0", Offset = "0x8B00AF0", VA = "0x188B024F0")]
	static ILJGLLBOEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8B02380", Offset = "0x8B00980", VA = "0x188B02380")]
	public static IReadOnlyList<KNGGJOLCIAP> EBJMKEPNBDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DCLDMHJDHDN : NCIJHILAJIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MFGGAMGFGBM : KNGGJOLCIAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class CAFEFCHENOG
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
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public CAFEFCHENOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B01E50", Offset = "0x8B00450", VA = "0x188B01E50")]
			internal void PIMHMOPLIOA(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice CJPCGODGIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JKOIKGOFNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CMFDGKEKOHH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KNEGKBBPKJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8B02660", Offset = "0x8B00C60", VA = "0x188B02660", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DGJFAOEKPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JMNOIDFONLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE45C10", Offset = "0xE44210", VA = "0x180E45C10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8B02680", Offset = "0x8B00C80", VA = "0x188B02680", Slot = "7")]
		public IKKIDJCKFCM OJDOAJAAAIH(Action<ArraySegment<float>> BNOBGIHHJGL)
		{
			return default(IKKIDJCKFCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8B026B0", Offset = "0x8B00CB0", VA = "0x188B026B0")]
		private IKKIDJCKFCM OJDOAJAAAIH(int BLINAAHKHFN, int ACAFKLDDHHD, int ADCCACNEHOB, Action<ArraySegment<float>> BNOBGIHHJGL)
		{
			return default(IKKIDJCKFCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8B025E0", Offset = "0x8B00BE0", VA = "0x188B025E0", Slot = "8")]
		public void FIAIGIFIMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B02A70", Offset = "0x8B01070", VA = "0x188B02A70")]
		public MFGGAMGFGBM(MMDevice CJPCGODGIBC, bool KOKLODBGJLD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MFGGAMGFGBM> DBFICPEGCLO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GFADCEIHOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8B01FD0", Offset = "0x8B005D0", VA = "0x188B01FD0", Slot = "5")]
	public IReadOnlyList<KNGGJOLCIAP> EBJMKEPNBDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8B022F0", Offset = "0x8B008F0", VA = "0x188B022F0")]
	public DCLDMHJDHDN()
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
