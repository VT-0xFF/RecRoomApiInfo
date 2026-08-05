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
public class OEMMNLFMPMN : ACOCFCCKHLM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class NAEKMMHMBPG : PJGHCBKFNBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class CPGBNEGINEL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public CPGBNEGINEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6F9B880", Offset = "0x6F9AC80", VA = "0x186F9B880")]
			internal void DKGHALDBKPH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice BHKNKLFPKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture ILJLACDIDND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource BHHJFCDMOAN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string MCNCONKIDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6F9C0B0", Offset = "0x6F9B4B0", VA = "0x186F9C0B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KLOKLDKLNEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x977980", Offset = "0x976D80", VA = "0x180977980", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x977870", Offset = "0x976C70", VA = "0x180977870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CGHAGGEDDAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x144D9F0", Offset = "0x144CDF0", VA = "0x18144D9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C000", Offset = "0x6F9B400", VA = "0x186F9C000", Slot = "7")]
		public EPGPMIJJJDC CCNFCHLKPFI(Action<ArraySegment<float>> GBCKPIBLKJM)
		{
			return default(EPGPMIJJJDC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BC60", Offset = "0x6F9B060", VA = "0x186F9BC60")]
		private EPGPMIJJJDC CCNFCHLKPFI(int FFNNAKNMNMO, int LMMDEMDIJBL, int IGPJPHHKFNG, Action<ArraySegment<float>> GBCKPIBLKJM)
		{
			return default(EPGPMIJJJDC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C030", Offset = "0x6F9B430", VA = "0x186F9C030", Slot = "8")]
		public void JBELPGDLFNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9C0D0", Offset = "0x6F9B4D0", VA = "0x186F9C0D0")]
		public NAEKMMHMBPG(MMDevice BHKNKLFPKFL, bool HADAAHDMCNI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<NAEKMMHMBPG> NBLMFMKFPBO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GLDBKPAAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FFD60", Offset = "0x7FF160", VA = "0x1807FFD60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C120", Offset = "0x6F9B520", VA = "0x186F9C120", Slot = "5")]
	public IReadOnlyList<PJGHCBKFNBF> DIFCIDEHJCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F9C3F0", Offset = "0x6F9B7F0", VA = "0x186F9C3F0")]
	public OEMMNLFMPMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACOCFCCKHLM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool GLDBKPAAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PJGHCBKFNBF> DIFCIDEHJCI();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PJGHCBKFNBF
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string MCNCONKIDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KLOKLDKLNEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CGHAGGEDDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EPGPMIJJJDC CCNFCHLKPFI(Action<ArraySegment<float>> GBCKPIBLKJM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBELPGDLFNA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct EPGPMIJJJDC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EHEDNBPKDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBDECE0", Offset = "0xBDE0E0", VA = "0x180BDECE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D4800", Offset = "0x8D3C00", VA = "0x1808D4800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OGKEJJLAGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16CFC90", Offset = "0x16CF090", VA = "0x1816CFC90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2513720", Offset = "0x2512B20", VA = "0x182513720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BC50", Offset = "0x6F9B050", VA = "0x186F9BC50")]
	public EPGPMIJJJDC(int FFNNAKNMNMO, int IGPJPHHKFNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DEGADJPMMAD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static ACOCFCCKHLM EDKEDLEOENG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool GLDBKPAAGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F9BB00", Offset = "0x6F9AF00", VA = "0x186F9BB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BB80", Offset = "0x6F9AF80", VA = "0x186F9BB80")]
	static DEGADJPMMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F9BA10", Offset = "0x6F9AE10", VA = "0x186F9BA10")]
	public static IReadOnlyList<PJGHCBKFNBF> DIFCIDEHJCI()
	{
		return null;
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
