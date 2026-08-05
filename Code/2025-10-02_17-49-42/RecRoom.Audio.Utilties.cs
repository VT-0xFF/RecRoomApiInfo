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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8306170", Offset = "0x8304B70", VA = "0x188306170")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DJFHFFNOBHH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct HLEMLFLCLDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public DJFHFFNOBHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8305D20", Offset = "0x8304720", VA = "0x188305D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8306110", Offset = "0x8304B10", VA = "0x188306110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float APCMJOAKAOC = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float AJEIINDGOAB = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int MLNNAIMBNFC = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int MCAKEJBBCAG = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int FNNGLOMOPDC = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int EAFNMNHMGFF = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float BNMLMLHBNFC = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip FEEHHKJABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource FNBEJKIAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] PEIAIEMBMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int JGOLAMDDEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int JDBLHANCFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int JGGDADPAGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KPIDAIALJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool JCPCABOFKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool LMLALLPAAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool KPPEFLHPHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int IACCMCLMBFP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool BLPFKBIDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AD49C0", Offset = "0x2AD33C0", VA = "0x182AD49C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8305550", Offset = "0x8303F50", VA = "0x188305550")]
	public DJFHFFNOBHH(AudioSource FNBEJKIAEFA, string IELIBBNCJAC, bool KPPEFLHPHIJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83051B0", Offset = "0x8303BB0", VA = "0x1883051B0")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8304E90", Offset = "0x8303890", VA = "0x188304E90")]
	[AsyncStateMachine(typeof(HLEMLFLCLDP))]
	public Task AGPGOMHOJNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8304F60", Offset = "0x8303960", VA = "0x188304F60")]
	public void CPIMJLFEPPG(float[] LKIKBPKKCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x83052A0", Offset = "0x8303CA0", VA = "0x1883052A0")]
	private void LFLPDHDCGNI(float[] BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private void FMFCBBEEKKC(int MJBMEPCOMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8305200", Offset = "0x8303C00", VA = "0x188305200", Slot = "4")]
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
		public delegate void KLOFOELDENL(float[] BLPDDGCLNPE, int MCAKEJBBCAG, int HGCOIPKMAAD);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int FKMPMCNMHLD;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KLOFOELDENL? LFLPDHDCGNI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8305840", Offset = "0x8304240", VA = "0x188305840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x83058E0", Offset = "0x83042E0", VA = "0x1883058E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83057B0", Offset = "0x83041B0", VA = "0x1883057B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8305730", Offset = "0x8304130", VA = "0x188305730")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8305700", Offset = "0x8304100", VA = "0x188305700")]
		private void OnAudioFilterRead(float[] BLPDDGCLNPE, int MCAKEJBBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83056E0", Offset = "0x83040E0", VA = "0x1883056E0")]
		private void DLFAOPLANEN(bool KLLPBEPANDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MKMCJCBBACM<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class JAAEFLKEHAJ : IEquatable<JAAEFLKEHAJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type HCMMHEKOCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5522200", Offset = "0x5520C00", VA = "0x185522200", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId BKICOPKGOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? AMLFHELBNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x12D0950", Offset = "0x12CF350", VA = "0x1812D0950")]
		public JAAEFLKEHAJ(TAudioClipId BKICOPKGOOC, IMemoryOwner<byte>? AMLFHELBNMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x55223D0", Offset = "0x5520DD0", VA = "0x1855223D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x55219E0", Offset = "0x55203E0", VA = "0x1855219E0", Slot = "6")]
		protected virtual bool ECBFINKPGDH(StringBuilder EAHPNFLHNJH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12D07B0", Offset = "0x12CF1B0", VA = "0x1812D07B0")]
		public static bool NOPNAEDOCOI(JAAEFLKEHAJ? FKHOLJEDBPC, JAAEFLKEHAJ? EEAEODONEDA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x55220C0", Offset = "0x5520AC0", VA = "0x1855220C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5127490", Offset = "0x5125E90", VA = "0x185127490", Slot = "0")]
		public override bool Equals(object? PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5521E10", Offset = "0x5520810", VA = "0x185521E10", Slot = "7")]
		public virtual bool Equals(JAAEFLKEHAJ? GOCNHGEHNFD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class MLKCBKPNJMC : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] KNJHGKFJLEL;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> IEOHDFOKHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x59EA660", Offset = "0x59E9060", VA = "0x1859EA660")]
		public MLKCBKPNJMC(byte[] BHEONMJLANC, int AJDEGEPLAEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x59EA5E0", Offset = "0x59E8FE0", VA = "0x1859EA5E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int MMEBNLKBBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<JAAEFLKEHAJ> IIKDKGLAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? PJECFIMKKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? PBLKLEDKJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int HNPMHIJGFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private OIGHFHHLACH? KLECMCBILJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AHDLCNFLGGK<TAudioClipId> IJIKOPNJNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public AHDLCNFLGGK<TAudioClipId> OPDNGAMOMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FONIFJMDCJB<TAudioClipId, int> IIEKKFGANPH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x596E830", Offset = "0x596D230", VA = "0x18596E830")]
	public MKMCJCBBACM(OIGHFHHLACH FNBEJKIAEFA, int LPMJNGJKIGI = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x596AF40", Offset = "0x5969940", VA = "0x18596AF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x596B580", Offset = "0x5969F80", VA = "0x18596B580")]
	public void FEIFCIKIDMP(TAudioClipId NMAIBBDGPCD, string AOPHCOCAFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x596AB10", Offset = "0x5969510", VA = "0x18596AB10")]
	public void AMDPHDJEJDC(TAudioClipId NMAIBBDGPCD, IMemoryOwner<byte> AOPHCOCAFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x596D850", Offset = "0x596C250", VA = "0x18596D850")]
	public void JGOIFBCIJIF(TAudioClipId NMAIBBDGPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x596C090", Offset = "0x596AA90", VA = "0x18596C090")]
	public void GONJDEBADEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x596ADD0", Offset = "0x59697D0", VA = "0x18596ADD0")]
	private bool DHBOBCMJOCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x596DB00", Offset = "0x596C500", VA = "0x18596DB00")]
	private void LFLPDHDCGNI(float[] NDJLLMKLLAG, int CMNDOPLMADP, int HDCMNIHLEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x596D050", Offset = "0x596BA50", VA = "0x18596D050")]
	private void HKIOBHDFKIO(byte[] FPGJFOLEKAK, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x596E0E0", Offset = "0x596CAE0", VA = "0x18596E0E0")]
	private bool MODIBPCHJLM(JAAEFLKEHAJ AHFIEKCIAJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x596B110", Offset = "0x5969B10", VA = "0x18596B110")]
	private static void FECBJCPAAEA(byte[] BNICMFHPCJC, float[] JMLKHEOLOFG, int DCDNANOCACJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x596E060", Offset = "0x596CA60", VA = "0x18596E060")]
	private static void LLFBIPLKGNN(float[] PBOCDEMNFLD, float[] EDNHDPIMANI, int DCDNANOCACJ, int MCAKEJBBCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x596E280", Offset = "0x596CC80", VA = "0x18596E280")]
	private static void NNMMKBDEGCE(float[] PBOCDEMNFLD, float[] EDNHDPIMANI, int DCDNANOCACJ, int MCAKEJBBCAG, float CDJLBKJAGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x596AFB0", Offset = "0x59699B0", VA = "0x18596AFB0")]
	private static float EOLAHOBGGEN(ReadOnlySpan<float> BLPDDGCLNPE, int HBDKIKFKCEE, int MCAKEJBBCAG, float CDJLBKJAGOL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FHNIGAEOCKF : OIGHFHHLACH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource OJPNHKLDPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? JBPBMPFHABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private OIGHFHHLACH.GDHKHNHBEOD? DPDIIGDONGH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KPOLDAAHPLJ<float[], int, int>? KDONEEDHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xEAC300", Offset = "0xEAAD00", VA = "0x180EAC300")]
	public FHNIGAEOCKF(AudioSource FNBEJKIAEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8305AF0", Offset = "0x83044F0", VA = "0x188305AF0", Slot = "5")]
	public void GFALNPPLGKO(OIGHFHHLACH.MMPCEDGKPGF KLEAHLCFPJJ, OIGHFHHLACH.GDHKHNHBEOD DIOEODACJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
	public AudioSource AOBFLNPNGHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8305C80", Offset = "0x8304680", VA = "0x188305C80")]
	private void LFLPDHDCGNI(float[] BLPDDGCLNPE, int MCAKEJBBCAG, int HGCOIPKMAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8305980", Offset = "0x8304380", VA = "0x188305980", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OIGHFHHLACH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool MMPCEDGKPGF();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void GDHKHNHBEOD(float[] BLPDDGCLNPE, int MCAKEJBBCAG, int HGCOIPKMAAD);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KPOLDAAHPLJ<float[], int, int> KDONEEDHHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFALNPPLGKO(MMPCEDGKPGF KLEAHLCFPJJ, GDHKHNHBEOD DIOEODACJKB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource AOBFLNPNGHC();
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
