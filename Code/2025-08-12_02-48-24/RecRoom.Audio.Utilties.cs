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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x82779D0", Offset = "0x8275FD0", VA = "0x1882779D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OHCMDECMLLO : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GLGCPDBNFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public OHCMDECMLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8277580", Offset = "0x8275B80", VA = "0x188277580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8277970", Offset = "0x8275F70", VA = "0x188277970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float ODFPALAOEEE = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float MHNANJLHOHN = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int NNPCCAGFFGB = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int FPJPLDGHLOG = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int NDPHFPFBHLH = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int GMFOLEDFPFH = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float FPHDALCHEGD = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip OIKPANNKPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource FDHHMJDPGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] LKGGEFIODAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MCPBDIMHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int ONDFJHAELIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int KLEHLGCIIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool HLAGAJJNFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool DMNLHLGKNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool OHKCDOGBJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool DCOGIGBIJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int GPKJGKBGLIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool PPFOBLPGEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A66E10", Offset = "0x2A65410", VA = "0x182A66E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8278110", Offset = "0x8276710", VA = "0x188278110")]
	public OHCMDECMLLO(AudioSource FDHHMJDPGCH, string DJFMCHMDHGK, bool DCOGIGBIJJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8277BC0", Offset = "0x82761C0", VA = "0x188277BC0")]
	public void FLHPFKIPOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8277A50", Offset = "0x8276050", VA = "0x188277A50")]
	[AsyncStateMachine(typeof(GLGCPDBNFFC))]
	public Task CKPGFMABHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8277C10", Offset = "0x8276210", VA = "0x188277C10")]
	public void IJHOJAEIAEI(float[] PFBGOGPBJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8277E60", Offset = "0x8276460", VA = "0x188277E60")]
	private void KGAGJOFBJHF(float[] DAJAOHIJHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private void KGBJDEOMDLK(int CMNDAAHGGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8277B20", Offset = "0x8276120", VA = "0x188277B20", Slot = "4")]
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
		public delegate void AOPBGOBGOBK(float[] DAJAOHIJHHL, int FPJPLDGHLOG, int LGGEJMJANBC);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int EKHJFPINAFA;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AOPBGOBGOBK? KGAGJOFBJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x82770A0", Offset = "0x82756A0", VA = "0x1882770A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8277140", Offset = "0x8275740", VA = "0x188277140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8277010", Offset = "0x8275610", VA = "0x188277010")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8276F90", Offset = "0x8275590", VA = "0x188276F90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8276F60", Offset = "0x8275560", VA = "0x188276F60")]
		private void OnAudioFilterRead(float[] DAJAOHIJHHL, int FPJPLDGHLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8276F40", Offset = "0x8275540", VA = "0x188276F40")]
		private void GLKDKHGMBAC(bool DJHLPFBNKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MCMCKJNGAKE<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class OCCDHHKFLGB : IEquatable<OCCDHHKFLGB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type IDPJOIDDLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5B3B1B0", Offset = "0x5B397B0", VA = "0x185B3B1B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId AFPIOPNCMPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEADD50", Offset = "0xEAC350", VA = "0x180EADD50")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? AIJFAAIOPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x129ACC0", Offset = "0x12992C0", VA = "0x18129ACC0")]
		public OCCDHHKFLGB(TAudioClipId AFPIOPNCMPM, IMemoryOwner<byte>? AIJFAAIOPNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B270", Offset = "0x5B39870", VA = "0x185B3B270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B3ADD0", Offset = "0x5B393D0", VA = "0x185B3ADD0", Slot = "6")]
		protected virtual bool FEEJNMKOALE(StringBuilder MBGGGJHKEDJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x129AAE0", Offset = "0x12990E0", VA = "0x18129AAE0")]
		public static bool LMIMJGGKHMP(OCCDHHKFLGB? KCALPCMINJB, OCCDHHKFLGB? LLDLIDKIBDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B070", Offset = "0x5B39670", VA = "0x185B3B070", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x54C7600", Offset = "0x54C5C00", VA = "0x1854C7600", Slot = "0")]
		public override bool Equals(object? NDBJJGOPOFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B3AAF0", Offset = "0x5B390F0", VA = "0x185B3AAF0", Slot = "7")]
		public virtual bool Equals(OCCDHHKFLGB? IBCMCOKAJEM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class CIAFLGHLACB : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] PGJHMFCHFJG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> EFNMMGIEJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD84C50", Offset = "0xD83250", VA = "0x180D84C50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3EA0", Offset = "0x6DE24A0", VA = "0x186DE3EA0")]
		public CIAFLGHLACB(byte[] OHHBFAGELLA, int FODNOPLPBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DE3DA0", Offset = "0x6DE23A0", VA = "0x186DE3DA0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int GIPGGKMLDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<OCCDHHKFLGB> HAODGEMMPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? JAIMCEPEIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? OGEFMPPDHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int PDACBKFFCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private EKLHAIIBLEI? GOLMKHCFCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GJIKMKGBNOL<TAudioClipId> IEOBJDNHFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GJIKMKGBNOL<TAudioClipId> OAAAGEMNNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NCECCJAFPPJ<TAudioClipId, int> KLDCCGCHKLA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x594CF70", Offset = "0x594B570", VA = "0x18594CF70")]
	public MCMCKJNGAKE(EKLHAIIBLEI FDHHMJDPGCH, int IMDCHBODLCM = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x594A390", Offset = "0x5948990", VA = "0x18594A390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x594A830", Offset = "0x5948E30", VA = "0x18594A830")]
	public void EOKJEDHOLPN(TAudioClipId JIEJOKBHEMF, string CGFMINAMLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x594ADE0", Offset = "0x59493E0", VA = "0x18594ADE0")]
	public void IKPDMJLMLBN(TAudioClipId JIEJOKBHEMF, IMemoryOwner<byte> CGFMINAMLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x594BA50", Offset = "0x594A050", VA = "0x18594BA50")]
	public void NHBKMPGLKDB(TAudioClipId JIEJOKBHEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x594BD00", Offset = "0x594A300", VA = "0x18594BD00")]
	public void OPGFAKICHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x594AF50", Offset = "0x5949550", VA = "0x18594AF50")]
	private bool JAJOGKPKIEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x594B350", Offset = "0x5949950", VA = "0x18594B350")]
	private void KGAGJOFBJHF(float[] KIHGLICFMPD, int BCKPEHNLEIE, int BMEPKCHCIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5949410", Offset = "0x5947A10", VA = "0x185949410")]
	private void DGCHMFBCNGK(byte[] COEFMBJKIKA, int FODNOPLPBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x594B8B0", Offset = "0x5949EB0", VA = "0x18594B8B0")]
	private bool LDNAPECGCEK(OCCDHHKFLGB DPJIKCMJAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5949360", Offset = "0x5947960", VA = "0x185949360")]
	private static void CCCMAEPEPMM(byte[] NCMOHOAIBBB, float[] IJGOJKMKPFG, int MBMOODBEJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x594AC00", Offset = "0x5949200", VA = "0x18594AC00")]
	private static void FKBLKOOHAOH(float[] LBHNPIBFMBH, float[] KAGGBDPGCAH, int MBMOODBEJBN, int FPJPLDGHLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x594B1D0", Offset = "0x59497D0", VA = "0x18594B1D0")]
	private static void KDGCEIOJMLJ(float[] LBHNPIBFMBH, float[] KAGGBDPGCAH, int MBMOODBEJBN, int FPJPLDGHLOG, float MNGINBMFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x59492B0", Offset = "0x59478B0", VA = "0x1859492B0")]
	private static float ANGKLDFGGLC(ReadOnlySpan<float> DAJAOHIJHHL, int IEODBGLFEOD, int FPJPLDGHLOG, float MNGINBMFCEK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FMGGNGFBJKK : EKLHAIIBLEI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource EGGNBKCLBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? KFJBIOPGOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EKLHAIIBLEI.ODMBHNMGLKB? NIIFOGHBNAN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FENKKBHLGFH<float[], int, int>? HKEHBKCMCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xE87A90", Offset = "0xE86090", VA = "0x180E87A90")]
	public FMGGNGFBJKK(AudioSource FDHHMJDPGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x82773F0", Offset = "0x82759F0", VA = "0x1882773F0", Slot = "5")]
	public void LJDCNOCKLGC(EKLHAIIBLEI.DIINHAHCDPF KFBJNLNGFAC, EKLHAIIBLEI.ODMBHNMGLKB ICDKFEHGBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA94390", Offset = "0xA92990", VA = "0x180A94390", Slot = "6")]
	public AudioSource MPIMDAMLCMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8277350", Offset = "0x8275950", VA = "0x188277350")]
	private void KGAGJOFBJHF(float[] DAJAOHIJHHL, int FPJPLDGHLOG, int LGGEJMJANBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x82771E0", Offset = "0x82757E0", VA = "0x1882771E0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EKLHAIIBLEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool DIINHAHCDPF();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void ODMBHNMGLKB(float[] DAJAOHIJHHL, int FPJPLDGHLOG, int LGGEJMJANBC);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FENKKBHLGFH<float[], int, int> HKEHBKCMCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJDCNOCKLGC(DIINHAHCDPF KFBJNLNGFAC, ODMBHNMGLKB ICDKFEHGBBI);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource MPIMDAMLCMB();
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
