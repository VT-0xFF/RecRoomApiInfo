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
public class JIMGJELDINP : IIKEEABJFLN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class HDKKCEDEOED : IPIOINHLNLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class FFCEHPCMKIK
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
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public FFCEHPCMKIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x159DDC0", Offset = "0x159CFC0", VA = "0x18159DDC0")]
			internal void NPIBCFGBGKB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice IGDFHBOJIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture HBGCHPKLJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource JEOEGPPBGNE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string OIHJKBDOAMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x159E3A0", Offset = "0x159D5A0", VA = "0x18159E3A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JJLDIOPEBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x98C9A0", Offset = "0x98BBA0", VA = "0x18098C9A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x98C990", Offset = "0x98BB90", VA = "0x18098C990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GBOOAJIBHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x917A60", Offset = "0x916C60", VA = "0x180917A60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x159DFD0", Offset = "0x159D1D0", VA = "0x18159DFD0", Slot = "7")]
		public ALNIOENBCIO CEPDOPFHLDG(Action<ArraySegment<float>> NMCNKNBHPHF)
		{
			return default(ALNIOENBCIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x159E000", Offset = "0x159D200", VA = "0x18159E000")]
		private ALNIOENBCIO CEPDOPFHLDG(int NCHEHALPBJJ, int HPADFJFODPA, int CPDMIONEKIG, Action<ArraySegment<float>> NMCNKNBHPHF)
		{
			return default(ALNIOENBCIO);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x159DF50", Offset = "0x159D150", VA = "0x18159DF50", Slot = "8")]
		public void BJOLFOHCILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x159E3C0", Offset = "0x159D5C0", VA = "0x18159E3C0")]
		public HDKKCEDEOED(MMDevice IGDFHBOJIJC, bool GMMMPFJOKHF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<HDKKCEDEOED> BANNOEBEABA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MFMJPOPFGCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x844770", Offset = "0x843970", VA = "0x180844770", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x159E410", Offset = "0x159D610", VA = "0x18159E410", Slot = "5")]
	public IReadOnlyList<IPIOINHLNLG> HFBMJDIADJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x159E6E0", Offset = "0x159D8E0", VA = "0x18159E6E0")]
	public JIMGJELDINP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IIKEEABJFLN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MFMJPOPFGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IPIOINHLNLG> HFBMJDIADJK();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IPIOINHLNLG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string OIHJKBDOAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JJLDIOPEBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GBOOAJIBHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ALNIOENBCIO CEPDOPFHLDG(Action<ArraySegment<float>> NMCNKNBHPHF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BJOLFOHCILP();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ALNIOENBCIO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BKMCLLFJFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x985170", Offset = "0x984370", VA = "0x180985170")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x985240", Offset = "0x984440", VA = "0x180985240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MKPDCGGIHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC56930", Offset = "0xC55B30", VA = "0x180C56930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x159B400", Offset = "0x159A600", VA = "0x18159B400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x159DDB0", Offset = "0x159CFB0", VA = "0x18159DDB0")]
	public ALNIOENBCIO(int NCHEHALPBJJ, int CPDMIONEKIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KLBEONJBDND
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static IIKEEABJFLN PNAGJFGNFIM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool MFMJPOPFGCL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x159E850", Offset = "0x159DA50", VA = "0x18159E850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x159E8D0", Offset = "0x159DAD0", VA = "0x18159E8D0")]
	static KLBEONJBDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x159E760", Offset = "0x159D960", VA = "0x18159E760")]
	public static IReadOnlyList<IPIOINHLNLG> HFBMJDIADJK()
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
