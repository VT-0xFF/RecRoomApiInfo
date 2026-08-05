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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F8AE70", Offset = "0x7F89E70", VA = "0x187F8AE70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DelegatingAudioFilter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public delegate void POOGPDLCCOI(float[] INCJDDLACNP, int CNKKHLMNAKG, int AELBFPLMDBC);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int ECFFADMANKG;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event POOGPDLCCOI? NLACPGPIBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7F89CF0", Offset = "0x7F88CF0", VA = "0x187F89CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7F89D90", Offset = "0x7F88D90", VA = "0x187F89D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F89C60", Offset = "0x7F88C60", VA = "0x187F89C60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F89BE0", Offset = "0x7F88BE0", VA = "0x187F89BE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F89BB0", Offset = "0x7F88BB0", VA = "0x187F89BB0")]
		private void OnAudioFilterRead(float[] INCJDDLACNP, int CNKKHLMNAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F89B90", Offset = "0x7F88B90", VA = "0x187F89B90")]
		private void LEMDNBMOEJO(bool PMICENNDKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA60510", Offset = "0xA5F510", VA = "0x180A60510")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OGEHCEBCHBK<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class DOLCMEBCHBJ : IEquatable<DOLCMEBCHBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual Type HENDJOPJCBH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x44A2CC0", Offset = "0x44A1CC0", VA = "0x1844A2CC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public TAudioClipId CMGKJAEFCGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE60", Offset = "0xE5DE60", VA = "0x180E5EE60")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IMemoryOwner<byte>? FGNOGEEOKID
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x12051E0", Offset = "0x12041E0", VA = "0x1812051E0")]
		public DOLCMEBCHBJ(TAudioClipId CMGKJAEFCGA, IMemoryOwner<byte>? FGNOGEEOKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x44A31B0", Offset = "0x44A21B0", VA = "0x1844A31B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x44A3050", Offset = "0x44A2050", VA = "0x1844A3050", Slot = "6")]
		protected virtual bool JOGJFECJHFK(StringBuilder FJCCOAKCNIN)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x12050A0", Offset = "0x12040A0", VA = "0x1812050A0")]
		public static bool PHGIAKEDBEK(DOLCMEBCHBJ? MACAGNGMFOK, DOLCMEBCHBJ? IHEPOLKBHPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x44A2F20", Offset = "0x44A1F20", VA = "0x1844A2F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x44A2E90", Offset = "0x44A1E90", VA = "0x1844A2E90", Slot = "0")]
		public override bool Equals(object? PGIOEBKALDP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x44A2D20", Offset = "0x44A1D20", VA = "0x1844A2D20", Slot = "7")]
		public virtual bool Equals(DOLCMEBCHBJ? EDJHHGMLKFA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MLBNIACFJOM : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly byte[] CGIHIBHPDMC;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Memory<byte> JJEAHPDFJIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x56DE330", Offset = "0x56DD330", VA = "0x1856DE330")]
		public MLBNIACFJOM(byte[] MFIJBPNIELL, int FCCMJLNEMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x56DE230", Offset = "0x56DD230", VA = "0x1856DE230", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int MBOBPOPJFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Queue<DOLCMEBCHBJ> EEJJCCLJEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private TAudioClipId? FKNEAEPJJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private Stopwatch? GJCKJABBFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int JBAJGHDEGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KKFDOJFDIGG? AJFBIEMIFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public FHLIAIDPCMK<TAudioClipId> ECMEOGPJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FHLIAIDPCMK<TAudioClipId> GDFGFPBONIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public MDNONHHFIOF<TAudioClipId, int> OBDBMLMLJMJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x58ABFA0", Offset = "0x58AAFA0", VA = "0x1858ABFA0")]
	public OGEHCEBCHBK(KKFDOJFDIGG IOFHCDLLALA, int LNFOJMDJCDJ = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58AA980", Offset = "0x58A9980", VA = "0x1858AA980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x58ABA80", Offset = "0x58AAA80", VA = "0x1858ABA80")]
	public void OMKJECGNLEG(TAudioClipId PBJHGGBBAAF, string KGLDEDJPBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58ABE40", Offset = "0x58AAE40", VA = "0x1858ABE40")]
	public void PLCINMKOCDN(TAudioClipId PBJHGGBBAAF, IMemoryOwner<byte> KGLDEDJPBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58AAC10", Offset = "0x58A9C10", VA = "0x1858AAC10")]
	public void GPBIHDBPGBD(TAudioClipId PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x58AA180", Offset = "0x58A9180", VA = "0x1858AA180")]
	public void BNOEMJCIFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x58AA090", Offset = "0x58A9090", VA = "0x1858AA090")]
	private bool BBCAEJEKCFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x58AB730", Offset = "0x58AA730", VA = "0x1858AB730")]
	private void NLACPGPIBAJ(float[] MCEELEPHMFH, int CHDIPNEAENE, int EAMNNNCIAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x58AAD60", Offset = "0x58A9D60", VA = "0x1858AAD60")]
	private void HMNOHOFKMPL(byte[] MPPMMFHHGAK, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x58AB5A0", Offset = "0x58AA5A0", VA = "0x1858AB5A0")]
	private bool NIEJBFCAHEG(DOLCMEBCHBJ DHMLKDJBAGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x58AA9F0", Offset = "0x58A99F0", VA = "0x1858AA9F0")]
	private static void EEJENAGIHGC(byte[] ODOOLGJOBIG, float[] MBBGLMAPODE, int LMODHPMHPMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x58AB520", Offset = "0x58AA520", VA = "0x1858AB520")]
	private static void KDOFPMLJFNI(float[] MKOOPFGGHLN, float[] LLJAAOFGKGM, int LMODHPMHPMB, int CNKKHLMNAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x58AAAA0", Offset = "0x58A9AA0", VA = "0x1858AAAA0")]
	private static void FGFEOLMBEEH(float[] MKOOPFGGHLN, float[] LLJAAOFGKGM, int LMODHPMHPMB, int CNKKHLMNAKG, float AOLKOOAJBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58AB9D0", Offset = "0x58AA9D0", VA = "0x1858AB9D0")]
	private static float OEJJEOFBECB(ReadOnlySpan<float> INCJDDLACNP, int LFBGKHDOJNO, int CNKKHLMNAKG, float AOLKOOAJBCE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MOIKIIGEGBE : KKFDOJFDIGG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AudioSource NHFKACGAEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DelegatingAudioFilter? OCDLJKPMDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private KKFDOJFDIGG.BBHLMNHGNEL? PIDEHGADKJA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GHCPNHMBOCA<float[], int, int>? IFCJOMCNODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xE3B5B0", Offset = "0xE3A5B0", VA = "0x180E3B5B0")]
	public MOIKIIGEGBE(AudioSource IOFHCDLLALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8ACE0", Offset = "0x7F89CE0", VA = "0x187F8ACE0", Slot = "5")]
	public void OCOPJMCPGIB(KKFDOJFDIGG.NNOCJMDKDFD PHCCBDLOMBG, KKFDOJFDIGG.BBHLMNHGNEL KAJHJEHGLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
	public AudioSource BFHKAEDIEAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AC40", Offset = "0x7F89C40", VA = "0x187F8AC40")]
	private void NLACPGPIBAJ(float[] INCJDDLACNP, int CNKKHLMNAKG, int AELBFPLMDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F8AAD0", Offset = "0x7F89AD0", VA = "0x187F8AAD0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KKFDOJFDIGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public delegate bool NNOCJMDKDFD();

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate void BBHLMNHGNEL(float[] INCJDDLACNP, int CNKKHLMNAKG, int AELBFPLMDBC);

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GHCPNHMBOCA<float[], int, int> IFCJOMCNODD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCOPJMCPGIB(NNOCJMDKDFD PHCCBDLOMBG, BBHLMNHGNEL KAJHJEHGLCF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource BFHKAEDIEAL();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KLIJAACLCKL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HDEFNCPLFEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KLIJAACLCKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7F89E30", Offset = "0x7F88E30", VA = "0x187F89E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F8A220", Offset = "0x7F89220", VA = "0x187F8A220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const float OGMCNKIKDHI = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FKLNNEFOJLE = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private const int PFDDOKCEOHP = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const int CNKKHLMNAKG = 1;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int NFNDAGNFJAB = 2;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private const int EDCDNCFLOGB = 96000;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private const float AHDFJOEIAOA = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private AudioClip HLOLMMGHOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private AudioSource IOFHCDLLALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private float[] LONHGIMLFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private int BJPBDKAJHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int CPGKGDOEDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private int OIMDHMGHPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private bool GCPOCCEPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool APDDGJMAIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private bool BJMJDJIGICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly bool IGJEEENMCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private int BCNCOKJNBHM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CEKPMMJFMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x29B17A0", Offset = "0x29B07A0", VA = "0x1829B17A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A940", Offset = "0x7F89940", VA = "0x187F8A940")]
	public KLIJAACLCKL(AudioSource IOFHCDLLALA, string HJLBILHBIIC, bool IGJEEENMCCI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A8F0", Offset = "0x7F898F0", VA = "0x187F8A8F0")]
	public void PHBANHJIEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A320", Offset = "0x7F89320", VA = "0x187F8A320")]
	[AsyncStateMachine(typeof(HDEFNCPLFEL))]
	public Task EDLNMOIJDGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A3F0", Offset = "0x7F893F0", VA = "0x187F8A3F0")]
	public void GMOGDPOCBBO(float[] BLDGHJHIAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A640", Offset = "0x7F89640", VA = "0x187F8A640")]
	private void NLACPGPIBAJ(float[] INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private void PGHLODDOLKI(int JEDFBKNAHJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F8A280", Offset = "0x7F89280", VA = "0x187F8A280", Slot = "4")]
	public void Dispose()
	{
	}
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
