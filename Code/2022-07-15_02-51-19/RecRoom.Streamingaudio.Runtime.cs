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
public interface FIOOBFMEEJD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GOJHKCEGDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GEKGJHNKHDK> FJBMCEOPKDJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GEKGJHNKHDK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KFKIJIIGHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HDPPGKAMNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FJCFCGBMBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLDOILGANKI MKDLCJCPPFC(Action<ArraySegment<float>> ONMGDGLPLME);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCJPAMEKKKH();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CLDOILGANKI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CHLDLILDONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84C200", Offset = "0x84B200", VA = "0x18084C200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8C67C0", Offset = "0x8C57C0", VA = "0x1808C67C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NHAIKOPNELL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E0", Offset = "0x84B1E0", VA = "0x18084C1E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89FFD0", Offset = "0x89EFD0", VA = "0x18089FFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5206BF0", Offset = "0x5205BF0", VA = "0x185206BF0")]
	public CLDOILGANKI(int ILDENPNADCB, int BBFMIKMGBNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GBLLDKIFILJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FIOOBFMEEJD KMGIAGIBMJD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GOJHKCEGDML
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5206D80", Offset = "0x5205D80", VA = "0x185206D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5206EE0", Offset = "0x5205EE0", VA = "0x185206EE0")]
	static GBLLDKIFILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5206DF0", Offset = "0x5205DF0", VA = "0x185206DF0")]
	public static IReadOnlyList<GEKGJHNKHDK> FJBMCEOPKDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PFODHHELPMA : FIOOBFMEEJD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HDLNKJNFDBK : GEKGJHNKHDK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DNOKHCOFMMK
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
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public DNOKHCOFMMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5206C00", Offset = "0x5205C00", VA = "0x185206C00")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PCCKDMEKCGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LFMPNEEJAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PAHLCKLNODL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KFKIJIIGHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5206F90", Offset = "0x5205F90", VA = "0x185206F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HDPPGKAMNJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x60E990", Offset = "0x60D990", VA = "0x18060E990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9DBE80", Offset = "0x9DAE80", VA = "0x1809DBE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FJCFCGBMBDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6A64F0", Offset = "0x6A54F0", VA = "0x1806A64F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5206FB0", Offset = "0x5205FB0", VA = "0x185206FB0", Slot = "7")]
		public CLDOILGANKI MKDLCJCPPFC(Action<ArraySegment<float>> ONMGDGLPLME)
		{
			return default(CLDOILGANKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5206FE0", Offset = "0x5205FE0", VA = "0x185206FE0")]
		private CLDOILGANKI MKDLCJCPPFC(int ILDENPNADCB, int LGIIGJFOIMM, int BBFMIKMGBNI, Action<ArraySegment<float>> ONMGDGLPLME)
		{
			return default(CLDOILGANKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5207320", Offset = "0x5206320", VA = "0x185207320", Slot = "8")]
		public void NCJPAMEKKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x52073A0", Offset = "0x52063A0", VA = "0x1852073A0")]
		public HDLNKJNFDBK(MMDevice PCCKDMEKCGJ, bool MHKFOKNMJJC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HDLNKJNFDBK> HKKKLAGBIEO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GOJHKCEGDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x52073F0", Offset = "0x52063F0", VA = "0x1852073F0", Slot = "5")]
	public IReadOnlyList<GEKGJHNKHDK> FJBMCEOPKDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5207690", Offset = "0x5206690", VA = "0x185207690")]
	public PFODHHELPMA()
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
