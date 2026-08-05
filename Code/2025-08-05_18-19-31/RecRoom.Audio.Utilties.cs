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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x80C2F00", Offset = "0x80C2300", VA = "0x1880C2F00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FGKONLHOGPB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct PIHCKENHDCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FGKONLHOGPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80C2F80", Offset = "0x80C2380", VA = "0x1880C2F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80C3370", Offset = "0x80C2770", VA = "0x1880C3370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float KLIIHNFPHPD = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float JFFKPHAIMEF = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int LPCFNLCCJGH = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int MBLOEPMGFGN = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int DADFHDHHIOF = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int ICODJACFHJP = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float JMBJNOMKNCL = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip LHOFGMMKCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource MPBPFGNEAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] OAGECLJDIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int EGKIJGGCPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int ADDFDPNFGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int CFCNBBLEDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool BLNOFLFPGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool CGDGGELHCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool BOKPHOHJJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool LBMINFPNKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int PGAKGJKEOED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool LFFCACHKKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29F8240", Offset = "0x29F7640", VA = "0x1829F8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80C29D0", Offset = "0x80C1DD0", VA = "0x1880C29D0")]
	public FGKONLHOGPB(AudioSource MPBPFGNEAOL, string HDNPPEBJPAE, bool LBMINFPNKOL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80C2730", Offset = "0x80C1B30", VA = "0x1880C2730")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80C2660", Offset = "0x80C1A60", VA = "0x1880C2660")]
	[AsyncStateMachine(typeof(PIHCKENHDCB))]
	public Task IECDMHOJHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x80C2780", Offset = "0x80C1B80", VA = "0x1880C2780")]
	public void OJLPEDBIEML(float[] OFICMPLDOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x80C2310", Offset = "0x80C1710", VA = "0x1880C2310")]
	private void DANMBMMBAAH(float[] NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private void JOGPFLLKGOJ(int LKOMPDMLLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x80C25C0", Offset = "0x80C19C0", VA = "0x1880C25C0", Slot = "4")]
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
		public delegate void FLHCGBCJMPA(float[] NGIAGNLBILI, int MBLOEPMGFGN, int FCFHMBNBOIH);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int IIIMLCOHAMF;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event FLHCGBCJMPA? DANMBMMBAAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80C21D0", Offset = "0x80C15D0", VA = "0x1880C21D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x80C2270", Offset = "0x80C1670", VA = "0x1880C2270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80C2120", Offset = "0x80C1520", VA = "0x1880C2120")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80C20A0", Offset = "0x80C14A0", VA = "0x1880C20A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80C2070", Offset = "0x80C1470", VA = "0x1880C2070")]
		private void OnAudioFilterRead(float[] NGIAGNLBILI, int MBLOEPMGFGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80C21B0", Offset = "0x80C15B0", VA = "0x1880C21B0")]
		private void PHPMHMBNCDL(bool PKIPEOCPMAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DGGPAKOBCKK<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class MFHGAJBDEGM : IEquatable<MFHGAJBDEGM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type EGGNAPINHGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5772A90", Offset = "0x5771E90", VA = "0x185772A90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId NGBODNHEHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xE6E090", Offset = "0xE6D490", VA = "0x180E6E090")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? NMPPAMCHJMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1244A70", Offset = "0x1243E70", VA = "0x181244A70")]
		public MFHGAJBDEGM(TAudioClipId NGBODNHEHKM, IMemoryOwner<byte>? NMPPAMCHJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5772B50", Offset = "0x5771F50", VA = "0x185772B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x57727E0", Offset = "0x5771BE0", VA = "0x1857727E0", Slot = "6")]
		protected virtual bool LAHPDPPCCNN(StringBuilder IDAMHGBLFLG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1244770", Offset = "0x1243B70", VA = "0x181244770")]
		public static bool ILMCFLMCOJH(MFHGAJBDEGM? DOGEBCJNCBM, MFHGAJBDEGM? CADKJEGELGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x57726B0", Offset = "0x5771AB0", VA = "0x1857726B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x52BDE40", Offset = "0x52BD240", VA = "0x1852BDE40", Slot = "0")]
		public override bool Equals(object? DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x57722B0", Offset = "0x57716B0", VA = "0x1857722B0", Slot = "7")]
		public virtual bool Equals(MFHGAJBDEGM? LHDOHAKINKP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class CAAKDLDMCOF : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] KBODHJJEFPN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> IFJGAGNOCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C81530", Offset = "0x6C80930", VA = "0x186C81530")]
		public CAAKDLDMCOF(byte[] LMLCJEFLFMP, int COONBEDHJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C814B0", Offset = "0x6C808B0", VA = "0x186C814B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int JOPBHFGMKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<MFHGAJBDEGM> JKBBDCEKNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? JEKCOCDFIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? LKMNMILIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int BDPIBBHAIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private IDKKGBGNNCH? KNEMCHGFIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public BBKKNBJGBDM<TAudioClipId> DAHCGIENGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BBKKNBJGBDM<TAudioClipId> JOEFOHHEPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NIFKGGOBKPN<TAudioClipId, int> KCHBNGPKDPD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45452F0", Offset = "0x45446F0", VA = "0x1845452F0")]
	public DGGPAKOBCKK(IDKKGBGNNCH MPBPFGNEAOL, int MHAHPKNJHFF = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x45427B0", Offset = "0x4541BB0", VA = "0x1845427B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4541B90", Offset = "0x4540F90", VA = "0x184541B90")]
	public void BKGLHMAHJLN(TAudioClipId CLNGGGMIBPI, string LBEJDBMDOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4542490", Offset = "0x4541890", VA = "0x184542490")]
	public void DFOOALIDHEI(TAudioClipId CLNGGGMIBPI, IMemoryOwner<byte> LBEJDBMDOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4542C40", Offset = "0x4542040", VA = "0x184542C40")]
	public void JADPBAFMDLA(TAudioClipId CLNGGGMIBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4542D90", Offset = "0x4542190", VA = "0x184542D90")]
	public void JHAGIJGMONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4544C80", Offset = "0x4544080", VA = "0x184544C80")]
	private bool MLAAKICNMAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45421F0", Offset = "0x45415F0", VA = "0x1845421F0")]
	private void DANMBMMBAAH(float[] FHAELKJDDEO, int MCNBGKMJBNG, int MPGMOFLFCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4543DB0", Offset = "0x45431B0", VA = "0x184543DB0")]
	private void MGLHPGICDJA(byte[] JCGBEKOGKKD, int COONBEDHJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4544ED0", Offset = "0x45442D0", VA = "0x184544ED0")]
	private bool OMJNEODNGFI(MFHGAJBDEGM CLJCNNOOIEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4543D00", Offset = "0x4543100", VA = "0x184543D00")]
	private static void JLAEAKDOFBE(byte[] FGHKEPJEKFP, float[] EDHJKNMJCJI, int HDAAOEBJNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4543C80", Offset = "0x4543080", VA = "0x184543C80")]
	private static void JIKOMGNKJJG(float[] NHDOFIDIKGL, float[] AHGBOFMNHGN, int HDAAOEBJNGA, int MBLOEPMGFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4542990", Offset = "0x4541D90", VA = "0x184542990")]
	private static void ICHGIBHHMNH(float[] NHDOFIDIKGL, float[] AHGBOFMNHGN, int HDAAOEBJNGA, int MBLOEPMGFGN, float HHEBIOLPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4544D70", Offset = "0x4544170", VA = "0x184544D70")]
	private static float NCKKNPCLGHB(ReadOnlySpan<float> NGIAGNLBILI, int PFKMHLGKANI, int MBLOEPMGFGN, float HHEBIOLPEJN)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KGCGJLIHGDF : IDKKGBGNNCH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource LIDDEIDDGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? AIEIIPFCDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IDKKGBGNNCH.OAAEHJALEBA? NDMOFEANIKL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FKJIGLNDBNB<float[], int, int>? IGHBCJEOAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xE4C1E0", Offset = "0xE4B5E0", VA = "0x180E4C1E0")]
	public KGCGJLIHGDF(AudioSource MPBPFGNEAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x80C2D70", Offset = "0x80C2170", VA = "0x1880C2D70", Slot = "5")]
	public void PJOFCLDPLJB(IDKKGBGNNCH.HJPBBNPHOMI LACEPEEHFJI, IDKKGBGNNCH.OAAEHJALEBA CIEJKGNCEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
	public AudioSource EADKFLGAANC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x80C2B60", Offset = "0x80C1F60", VA = "0x1880C2B60")]
	private void DANMBMMBAAH(float[] NGIAGNLBILI, int MBLOEPMGFGN, int FCFHMBNBOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x80C2C00", Offset = "0x80C2000", VA = "0x1880C2C00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IDKKGBGNNCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool HJPBBNPHOMI();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void OAAEHJALEBA(float[] NGIAGNLBILI, int MBLOEPMGFGN, int FCFHMBNBOIH);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FKJIGLNDBNB<float[], int, int> IGHBCJEOAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJOFCLDPLJB(HJPBBNPHOMI LACEPEEHFJI, OAAEHJALEBA CIEJKGNCEEF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource EADKFLGAANC();
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
