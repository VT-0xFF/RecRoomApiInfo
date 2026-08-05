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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x830FFB0", Offset = "0x830E5B0", VA = "0x18830FFB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NLPIJJPIDKD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GNJLFIEPEMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NLPIJJPIDKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x830F310", Offset = "0x830D910", VA = "0x18830F310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x830F700", Offset = "0x830DD00", VA = "0x18830F700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float CJLLKBCJKLE = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float BKFNDAGPPOB = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int DHMMLHNBLEA = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int NOJMAMBJJKK = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int HLJKECFLKPO = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int CNNJKKLCKIE = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float EDAIMPFDHAA = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip CDFIIPCBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource PBLDFAKOFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] NGMFGGCDLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int MJAKOKLDPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int OHNADCFMADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int MPBPAHIPPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool CINEOFBOCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool ANGKECPICGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HLLAFNKOLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool KPFFMPHCPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int KCPHHJHGLDA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool MJJHHFHIGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1EB0", Offset = "0x2AD04B0", VA = "0x182AD1EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x830FE20", Offset = "0x830E420", VA = "0x18830FE20")]
	public NLPIJJPIDKD(AudioSource PBLDFAKOFIK, string NDIENANOGEK, bool KPFFMPHCPAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x830FA50", Offset = "0x830E050", VA = "0x18830FA50")]
	public void FPGILMIKMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x830FAA0", Offset = "0x830E0A0", VA = "0x18830FAA0")]
	[AsyncStateMachine(typeof(GNJLFIEPEMK))]
	public Task GLPCOCKHBCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x830F760", Offset = "0x830DD60", VA = "0x18830F760")]
	public void BMBFCBNHLPD(float[] FMMLPNIJLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x830FB70", Offset = "0x830E170", VA = "0x18830FB70")]
	private void HPOEJDLHHJM(float[] CDDIADBJAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	private void JMGPBKHHPFP(int BAEGEJDEFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x830F9B0", Offset = "0x830DFB0", VA = "0x18830F9B0", Slot = "4")]
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
		public delegate void OFNBPAIEGAD(float[] CDDIADBJAOB, int NOJMAMBJJKK, int KBIICOGOBJL);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int PJLBAPMKJKD;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OFNBPAIEGAD? HPOEJDLHHJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x830F1D0", Offset = "0x830D7D0", VA = "0x18830F1D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x830F270", Offset = "0x830D870", VA = "0x18830F270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x830F140", Offset = "0x830D740", VA = "0x18830F140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x830F0C0", Offset = "0x830D6C0", VA = "0x18830F0C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x830F090", Offset = "0x830D690", VA = "0x18830F090")]
		private void OnAudioFilterRead(float[] CDDIADBJAOB, int NOJMAMBJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x830F070", Offset = "0x830D670", VA = "0x18830F070")]
		private void NCICBGMLJMA(bool EHLNAFKCHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IOANDDNAKFH<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class DFMIEJDDMKC : IEquatable<DFMIEJDDMKC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type MIPMFKLLDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x464D9E0", Offset = "0x464BFE0", VA = "0x18464D9E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId HMNNHOPLICJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? BJOBNNFAMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x12CB0A0", Offset = "0x12C96A0", VA = "0x1812CB0A0")]
		public DFMIEJDDMKC(TAudioClipId HMNNHOPLICJ, IMemoryOwner<byte>? BJOBNNFAMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x464DA40", Offset = "0x464C040", VA = "0x18464DA40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x464D6B0", Offset = "0x464BCB0", VA = "0x18464D6B0", Slot = "6")]
		protected virtual bool MGBJCLMFCPB(StringBuilder JMCGCJHMINI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12CAEE0", Offset = "0x12C94E0", VA = "0x1812CAEE0")]
		public static bool MGLHCKHANFO(DFMIEJDDMKC? BNHNFFDCFNM, DFMIEJDDMKC? JAENAFJMCLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x464D570", Offset = "0x464BB70", VA = "0x18464D570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x464D250", Offset = "0x464B850", VA = "0x18464D250", Slot = "0")]
		public override bool Equals(object? MPIDDJPOOMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x464D0D0", Offset = "0x464B6D0", VA = "0x18464D0D0", Slot = "7")]
		public virtual bool Equals(DFMIEJDDMKC? AAGCKLPFJME)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class KKIPDFKMMFL : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] GHJLLDPIAPH;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> LKOOMOCHCOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xBF19C0", Offset = "0xBEFFC0", VA = "0x180BF19C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x56B5B80", Offset = "0x56B4180", VA = "0x1856B5B80")]
		public KKIPDFKMMFL(byte[] GHKPAFFMJAO, int NODGHDHCBPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x56B5A20", Offset = "0x56B4020", VA = "0x1856B5A20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int HGDCILBEBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<DFMIEJDDMKC> LLBOODOHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? AFGOHCGGCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? CPMHDDHPCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int IMGJOLHFHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private ONGJGMGDIJF? OLOKHFAALNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public PKBDHHCMFJK<TAudioClipId> HHJFAMIMMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public PKBDHHCMFJK<TAudioClipId> GPMIFOMOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FCCGMMLDHAB<TAudioClipId, int> BDKGIOHKEIM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x52A5070", Offset = "0x52A3670", VA = "0x1852A5070")]
	public IOANDDNAKFH(ONGJGMGDIJF PBLDFAKOFIK, int KAIDHDMDFJJ = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x52A34B0", Offset = "0x52A1AB0", VA = "0x1852A34B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x52A30E0", Offset = "0x52A16E0", VA = "0x1852A30E0")]
	public void BCAJPADPPJD(TAudioClipId NMILEMOAODL, string NGAPFKFLCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x52A4350", Offset = "0x52A2950", VA = "0x1852A4350")]
	public void JGGHHBCJCAB(TAudioClipId NMILEMOAODL, IMemoryOwner<byte> NGAPFKFLCLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x52A3E90", Offset = "0x52A2490", VA = "0x1852A3E90")]
	public void HBCILEHEJHI(TAudioClipId NMILEMOAODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x52A3620", Offset = "0x52A1C20", VA = "0x1852A3620")]
	public void GDAINIOEEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x52A3520", Offset = "0x52A1B20", VA = "0x1852A3520")]
	private bool EGDLEKOAPOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x52A3FF0", Offset = "0x52A25F0", VA = "0x1852A3FF0")]
	private void HPOEJDLHHJM(float[] MPFMBCENJIM, int CHAOOGOEPAP, int LOFOBICMMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x52A4540", Offset = "0x52A2B40", VA = "0x1852A4540")]
	private void LHKAGBNODHG(byte[] DNGAEEFBGGO, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x52A4ED0", Offset = "0x52A34D0", VA = "0x1852A4ED0")]
	private bool OGLAEBKLIKB(DFMIEJDDMKC MAEBGFIAKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x52A3030", Offset = "0x52A1630", VA = "0x1852A3030")]
	private static void ALIOBMIEMIB(byte[] EIJIDGHNNNL, float[] HNAMOIKOGHA, int OIMCDEBJJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x52A44C0", Offset = "0x52A2AC0", VA = "0x1852A44C0")]
	private static void JHONKHMMCJA(float[] NGOJMGCIOHB, float[] PCCGPNIJDPB, int OIMCDEBJJAO, int NOJMAMBJJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52A4D50", Offset = "0x52A3350", VA = "0x1852A4D50")]
	private static void OAHIJJHCHFG(float[] NGOJMGCIOHB, float[] PCCGPNIJDPB, int OIMCDEBJJAO, int NOJMAMBJJKK, float JCAGMNALNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x52A42A0", Offset = "0x52A28A0", VA = "0x1852A42A0")]
	private static float IABBCMGCAKA(ReadOnlySpan<float> CDDIADBJAOB, int IFMKBBDLCHB, int NOJMAMBJJKK, float JCAGMNALNEN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BMBFENMPOLA : ONGJGMGDIJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource GABELGNIMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? NOCFLHPBFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private ONGJGMGDIJF.BEBIFMNKPDC? GBBOHAHGIAO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KBNGHJAFOPM<float[], int, int>? FBNMLPDKBBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xEB2B90", Offset = "0xEB1190", VA = "0x180EB2B90")]
	public BMBFENMPOLA(AudioSource PBLDFAKOFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x830ECD0", Offset = "0x830D2D0", VA = "0x18830ECD0", Slot = "5")]
	public void BDBKJLHAGCA(ONGJGMGDIJF.NIKPEGAJIKL KMICPDAKOLL, ONGJGMGDIJF.BEBIFMNKPDC BPLDIPLLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
	public AudioSource FJCILGIICJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x830EFD0", Offset = "0x830D5D0", VA = "0x18830EFD0")]
	private void HPOEJDLHHJM(float[] CDDIADBJAOB, int NOJMAMBJJKK, int KBIICOGOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x830EE60", Offset = "0x830D460", VA = "0x18830EE60", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ONGJGMGDIJF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool NIKPEGAJIKL();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void BEBIFMNKPDC(float[] CDDIADBJAOB, int NOJMAMBJJKK, int KBIICOGOBJL);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KBNGHJAFOPM<float[], int, int> FBNMLPDKBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDBKJLHAGCA(NIKPEGAJIKL KMICPDAKOLL, BEBIFMNKPDC BPLDIPLLMLH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource FJCILGIICJE();
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
