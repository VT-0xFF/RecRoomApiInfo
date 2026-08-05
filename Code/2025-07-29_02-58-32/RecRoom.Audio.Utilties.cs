using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Audio;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x811C900", Offset = "0x811B300", VA = "0x18811C900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HEHONDFAPEB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct KBGFHAAFIAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HEHONDFAPEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x811C4B0", Offset = "0x811AEB0", VA = "0x18811C4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x811C8A0", Offset = "0x811B2A0", VA = "0x18811C8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float HHAOPGHGIEM = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float LAPLBJDLHNF = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int FNENFIPNIEO = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int FFFBBGDMCAA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int BNCCDOBOKKA = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int MDBGBEKLLHI = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float GGMDBHBFPKB = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip GIBOOGMDHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource KBMMHDOGEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] GLIAFPKMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int KJLOKJGNDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int OPLLMPFNLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int DENFHGEAMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool OAOIPHMPHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool DFJCPHGIPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool JFHADNDLGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool PHNOAAAELGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int MICKMOLNMKB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool IAMNABKJMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29DE150", Offset = "0x29DCB50", VA = "0x1829DE150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x811BF80", Offset = "0x811A980", VA = "0x18811BF80")]
	public HEHONDFAPEB(AudioSource KBMMHDOGEHK, string FLBFBHGDBLM, bool PHNOAAAELGE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x811B8C0", Offset = "0x811A2C0", VA = "0x18811B8C0")]
	public void AIICKBIOPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x811BEB0", Offset = "0x811A8B0", VA = "0x18811BEB0")]
	[AsyncStateMachine(typeof(KBGFHAAFIAJ))]
	public Task PJDEEJFOLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x811BC60", Offset = "0x811A660", VA = "0x18811BC60")]
	public void NDOOLCIBJBP(float[] LGHEDKCDBEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x811B9B0", Offset = "0x811A3B0", VA = "0x18811B9B0")]
	private void JHAHFEKLDAL(float[] GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	private void BMNCOEBIELI(int PJNPHLDNCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x811B910", Offset = "0x811A310", VA = "0x18811B910", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DelegatingAudioFilter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate void AOFBPGOIDGB(float[] GPCDCFCPGFK, int FFFBBGDMCAA, int OBDDMOILNLM);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int DAJLAJHFJOO;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AOFBPGOIDGB? JHAHFEKLDAL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x811B780", Offset = "0x811A180", VA = "0x18811B780")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x811B820", Offset = "0x811A220", VA = "0x18811B820")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x811B6F0", Offset = "0x811A0F0", VA = "0x18811B6F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x811B670", Offset = "0x811A070", VA = "0x18811B670")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x811B640", Offset = "0x811A040", VA = "0x18811B640")]
		private void OnAudioFilterRead(float[] GPCDCFCPGFK, int FFFBBGDMCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x811B620", Offset = "0x811A020", VA = "0x18811B620")]
		private void DGKACDGMCFE(bool GOICFFBJNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NJLBMABHIJK<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class MHLBOEJAEDJ : IEquatable<MHLBOEJAEDJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type NLBACNKMDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5829E90", Offset = "0x5828890", VA = "0x185829E90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId BIKKNIIFDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xE823D0", Offset = "0xE80DD0", VA = "0x180E823D0")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? AKBOOJDMDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1269790", Offset = "0x1268190", VA = "0x181269790")]
		public MHLBOEJAEDJ(TAudioClipId BIKKNIIFDAP, IMemoryOwner<byte>? AKBOOJDMDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x582A160", Offset = "0x5828B60", VA = "0x18582A160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5829880", Offset = "0x5828280", VA = "0x185829880", Slot = "6")]
		protected virtual bool AICAJEMLONH(StringBuilder EBBBAHAEGHJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12695F0", Offset = "0x1267FF0", VA = "0x1812695F0")]
		public static bool JJNADAGGMDE(MHLBOEJAEDJ? KMGJNLBHING, MHLBOEJAEDJ? ELFIMJDHHOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5829EF0", Offset = "0x58288F0", VA = "0x185829EF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5044120", Offset = "0x5042B20", VA = "0x185044120", Slot = "0")]
		public override bool Equals(object? CEFJEHJNIAP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5829CB0", Offset = "0x58286B0", VA = "0x185829CB0", Slot = "7")]
		public virtual bool Equals(MHLBOEJAEDJ? EFNHKCDKOGH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class GDDCMGPNBGA : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] CCCCBFPDEBN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> DHJLGOHJOAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4F47D00", Offset = "0x4F46700", VA = "0x184F47D00")]
		public GDDCMGPNBGA(byte[] JCEJMKLBKKB, int KLLLBPFLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4F47C00", Offset = "0x4F46600", VA = "0x184F47C00", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int MIFFNGPPBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<MHLBOEJAEDJ> OFPAFONAFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? EOMGGDIPBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? GNCGIHJMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int PKFBJHMKKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KIMMDJFJABJ? JPODIHMCBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ECMKKKEPCGP<TAudioClipId> AOBAACNOMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ECMKKKEPCGP<TAudioClipId> GNKJPMBNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NCMMNGPOLDF<TAudioClipId, int> ECHFEJHGJDG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58C3A90", Offset = "0x58C2490", VA = "0x1858C3A90")]
	public NJLBMABHIJK(KIMMDJFJABJ KBMMHDOGEHK, int IGBHLCFONOG = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x58C1E50", Offset = "0x58C0850", VA = "0x1858C1E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x58C2D80", Offset = "0x58C1780", VA = "0x1858C2D80")]
	public void LNDDOKFBEMB(TAudioClipId EGJGKBPPPFG, string CCFPBNMADLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58C3670", Offset = "0x58C2070", VA = "0x1858C3670")]
	public void MIFJJHHNOPE(TAudioClipId EGJGKBPPPFG, IMemoryOwner<byte> CCFPBNMADLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x58C2010", Offset = "0x58C0A10", VA = "0x1858C2010")]
	public void FIBBBIECNFD(TAudioClipId EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58C0E20", Offset = "0x58BF820", VA = "0x1858C0E20")]
	public void CMLECHPCAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x58BFD20", Offset = "0x58BE720", VA = "0x1858BFD20")]
	private bool ANKMCNDJJEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x58C2720", Offset = "0x58C1120", VA = "0x1858C2720")]
	private void JHAHFEKLDAL(float[] CHKACLKPBHF, int DHADKHLANFG, int CBFLLLIAJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x58C0590", Offset = "0x58BEF90", VA = "0x1858C0590")]
	private void BHKHJMMFPEE(byte[] AEJOONCILAD, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x58C2170", Offset = "0x58C0B70", VA = "0x1858C2170")]
	private bool HIDHOHKLIAI(MHLBOEJAEDJ ACKOKCDHLEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x58C29D0", Offset = "0x58C13D0", VA = "0x1858C29D0")]
	private static void JLEFJLAFJKA(byte[] LHALFHPGBPD, float[] DNOOABMBLDN, int HHAIFHNNJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x58C0DA0", Offset = "0x58BF7A0", VA = "0x1858C0DA0")]
	private static void CHIJOEAOIEM(float[] PEIDNFHKHFH, float[] PDBEMMKOCBP, int HHAIFHNNJDI, int FFFBBGDMCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x58C2C00", Offset = "0x58C1600", VA = "0x1858C2C00")]
	private static void KBEDMNLBIID(float[] PEIDNFHKHFH, float[] PDBEMMKOCBP, int HHAIFHNNJDI, int FFFBBGDMCAA, float OEBEFCOGOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x58C2310", Offset = "0x58C0D10", VA = "0x1858C2310")]
	private static float HOOKMBFACGK(ReadOnlySpan<float> GPCDCFCPGFK, int LLLLOEKJOOH, int FFFBBGDMCAA, float OEBEFCOGOJO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ILGKLELMEMB : KIMMDJFJABJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource KGODDANBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? EIFAPHEOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private KIMMDJFJABJ.GCAHAGKPDID? IEGEADLMINF;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BNGHPJPHPGN<float[], int, int>? LKJGKCMLNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xE62940", Offset = "0xE61340", VA = "0x180E62940")]
	public ILGKLELMEMB(AudioSource KBMMHDOGEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x811C280", Offset = "0x811AC80", VA = "0x18811C280", Slot = "5")]
	public void ICNIAFDKEKI(KIMMDJFJABJ.HEPGPAGDEKN PJJEHNJKFPB, KIMMDJFJABJ.GCAHAGKPDID IDEHLKBODLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "6")]
	public AudioSource MKHKMLMHHKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x811C410", Offset = "0x811AE10", VA = "0x18811C410")]
	private void JHAHFEKLDAL(float[] GPCDCFCPGFK, int FFFBBGDMCAA, int OBDDMOILNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x811C110", Offset = "0x811AB10", VA = "0x18811C110", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KIMMDJFJABJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool HEPGPAGDEKN();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void GCAHAGKPDID(float[] GPCDCFCPGFK, int FFFBBGDMCAA, int OBDDMOILNLM);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BNGHPJPHPGN<float[], int, int> LKJGKCMLNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICNIAFDKEKI(HEPGPAGDEKN PJJEHNJKFPB, GCAHAGKPDID IDEHLKBODLN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource MKHKMLMHHKJ();
}
namespace Cpp2IlInjected
{
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
}
