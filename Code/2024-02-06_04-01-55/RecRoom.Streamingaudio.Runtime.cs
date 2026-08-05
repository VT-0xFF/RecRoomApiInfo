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
public interface FNIACFAPGPH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OFGLNPDKIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CHGKLMGKHHP> ICEKFBIHCCM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CHGKLMGKHHP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AHFHDEHNJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LKNALFHAIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FNDAALGKPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OOBPGIAFAKI JEJCNHENFOC(Action<ArraySegment<float>> KNDPECEGMIA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCJLKMEJOCL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OOBPGIAFAKI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DODCCEILGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88D230", Offset = "0x88C630", VA = "0x18088D230")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88D240", Offset = "0x88C640", VA = "0x18088D240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DNGEPDOFKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21AF6D0", Offset = "0x21AEAD0", VA = "0x1821AF6D0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x550F1E0", Offset = "0x550E5E0", VA = "0x18550F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67D2C90", Offset = "0x67D2090", VA = "0x1867D2C90")]
	public OOBPGIAFAKI(int DLLGFIKHNBK, int NBIIMMAFFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHOCDOEOGIO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FNIACFAPGPH KPIJBGCPIPH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OFGLNPDKIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67D2500", Offset = "0x67D1900", VA = "0x1867D2500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67D2670", Offset = "0x67D1A70", VA = "0x1867D2670")]
	static JHOCDOEOGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67D2580", Offset = "0x67D1980", VA = "0x1867D2580")]
	public static IReadOnlyList<CHGKLMGKHHP> ICEKFBIHCCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JMPLKIHPIFD : FNIACFAPGPH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FANGMKCKHLJ : CHGKLMGKHHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OBLHCNBLLEN
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
			[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
			public OBLHCNBLLEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67D2B10", Offset = "0x67D1F10", VA = "0x1867D2B10")]
			internal void OGCPKDABBFC(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BIHGDOHALPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GMPDBIKKDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EJPPFPKNKPD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AHFHDEHNJHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67D2490", Offset = "0x67D1890", VA = "0x1867D2490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LKNALFHAIBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87DA20", Offset = "0x87CE20", VA = "0x18087DA20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x936260", Offset = "0x935660", VA = "0x180936260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FNDAALGKPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC8AEE0", Offset = "0xC8A2E0", VA = "0x180C8AEE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67D2020", Offset = "0x67D1420", VA = "0x1867D2020", Slot = "7")]
		public OOBPGIAFAKI JEJCNHENFOC(Action<ArraySegment<float>> KNDPECEGMIA)
		{
			return default(OOBPGIAFAKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67D2050", Offset = "0x67D1450", VA = "0x1867D2050")]
		private OOBPGIAFAKI JEJCNHENFOC(int DLLGFIKHNBK, int KHNPMAJPKLD, int NBIIMMAFFBO, Action<ArraySegment<float>> KNDPECEGMIA)
		{
			return default(OOBPGIAFAKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67D2410", Offset = "0x67D1810", VA = "0x1867D2410", Slot = "8")]
		public void LCJLKMEJOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67D24B0", Offset = "0x67D18B0", VA = "0x1867D24B0")]
		public FANGMKCKHLJ(MMDevice BIHGDOHALPB, bool OBKLEAJOPCK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FANGMKCKHLJ> OOMNPECHLKM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OFGLNPDKIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2A0", Offset = "0x7B96A0", VA = "0x1807BA2A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67D2760", Offset = "0x67D1B60", VA = "0x1867D2760", Slot = "5")]
	public IReadOnlyList<CHGKLMGKHHP> ICEKFBIHCCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67D2A80", Offset = "0x67D1E80", VA = "0x1867D2A80")]
	public JMPLKIHPIFD()
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
