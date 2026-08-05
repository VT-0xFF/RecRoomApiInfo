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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x81A3850", Offset = "0x81A2650", VA = "0x1881A3850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NACGKGIPPCF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct MOFHBLFEFNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public NACGKGIPPCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private object <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81A2BB0", Offset = "0x81A19B0", VA = "0x1881A2BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81A2FA0", Offset = "0x81A1DA0", VA = "0x1881A2FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private const float IOPCNHJHCCE = 0.2f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private const float FALIHMADENJ = 0.7f;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private const int HBMEHOHOOGI = 48000;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private const int GBHDIJIKCIM = 1;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private const int ENPLOOKEKOB = 2;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private const int OGHIIDHPIGA = 96000;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private const float JPOPCPOOLEB = 0.5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private AudioClip PBPKCDFBNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private AudioSource FBABCNPBHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private float[] LNDBGEMBNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int PBPOCMHAJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private int MFBDPCDNMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int CKCCFLFBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool ABPGCPDDKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool AOMDBEBFBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool BPGMPKMFGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly bool LEECPGCGJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int DBHEOHMMHMB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private bool BIIKDIFOHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A46AE0", Offset = "0x2A458E0", VA = "0x182A46AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81A36C0", Offset = "0x81A24C0", VA = "0x1881A36C0")]
	public NACGKGIPPCF(AudioSource FBABCNPBHOI, string PFLDDMDPCBI, bool LEECPGCGJHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81A3000", Offset = "0x81A1E00", VA = "0x1881A3000")]
	public void AFCEEABIEMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81A30F0", Offset = "0x81A1EF0", VA = "0x1881A30F0")]
	[AsyncStateMachine(typeof(MOFHBLFEFNK))]
	public Task FDFEDBECCCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81A31C0", Offset = "0x81A1FC0", VA = "0x1881A31C0")]
	public void HLHKGGBBPDL(float[] FNDOGHMLALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81A3410", Offset = "0x81A2210", VA = "0x1881A3410")]
	private void IOOEKAHJJND(float[] KANAIIDGHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0")]
	private void BCFNPIPNJLD(int CBHDFFLGHBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x81A3050", Offset = "0x81A1E50", VA = "0x1881A3050", Slot = "4")]
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
		public delegate void OILIGPMKBGN(float[] KANAIIDGHCH, int GBHDIJIKCIM, int FMAPGJELDND);

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int JPHLKANHEFH;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OILIGPMKBGN? IOOEKAHJJND
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x81A2A70", Offset = "0x81A1870", VA = "0x1881A2A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x81A2B10", Offset = "0x81A1910", VA = "0x1881A2B10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81A29C0", Offset = "0x81A17C0", VA = "0x1881A29C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81A2940", Offset = "0x81A1740", VA = "0x1881A2940")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81A2910", Offset = "0x81A1710", VA = "0x1881A2910")]
		private void OnAudioFilterRead(float[] KANAIIDGHCH, int GBHDIJIKCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81A2A50", Offset = "0x81A1850", VA = "0x1881A2A50")]
		private void PKCAJAJMBAF(bool CCAEFIGEPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public DelegatingAudioFilter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HCPAMFEEKGC<TAudioClipId> : IDisposable where TAudioClipId : struct, IEquatable<TAudioClipId>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private class NKJJCNPGDHF : IEquatable<NKJJCNPGDHF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected virtual Type OEFOLDOCPHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5990B40", Offset = "0x598F940", VA = "0x185990B40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public TAudioClipId FBLHFPABBMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xEAB020", Offset = "0xEA9E20", VA = "0x180EAB020")]
			[CompilerGenerated]
			get
			{
				return (TAudioClipId)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IMemoryOwner<byte>? CFOLCKLFPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1288B00", Offset = "0x1287900", VA = "0x181288B00")]
		public NKJJCNPGDHF(TAudioClipId FBLHFPABBMB, IMemoryOwner<byte>? CFOLCKLFPKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5991530", Offset = "0x5990330", VA = "0x185991530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5990D60", Offset = "0x598FB60", VA = "0x185990D60", Slot = "6")]
		protected virtual bool EHGPOBJHANF(StringBuilder MFKHJJEIPDE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x12889A0", Offset = "0x12877A0", VA = "0x1812889A0")]
		public static bool IKIADGFKNFC(NKJJCNPGDHF? LIBGDNFNANP, NKJJCNPGDHF? ABBNFCGILDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x59911B0", Offset = "0x598FFB0", VA = "0x1859911B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5903690", Offset = "0x5902490", VA = "0x185903690", Slot = "0")]
		public override bool Equals(object? ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5990ED0", Offset = "0x598FCD0", VA = "0x185990ED0", Slot = "7")]
		public virtual bool Equals(NKJJCNPGDHF? FGAEAFBDBPK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class LFAOENBAIDP : IMemoryOwner<byte>, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly byte[] NJOGDPJJLIG;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Memory<byte> ONDCIABBGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD81A70", Offset = "0xD80870", VA = "0x180D81A70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Memory<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x56855C0", Offset = "0x56843C0", VA = "0x1856855C0")]
		public LFAOENBAIDP(byte[] ELLFIONNNHC, int MCJGICKIGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x56853E0", Offset = "0x56841E0", VA = "0x1856853E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly int HOPEJGPMELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Queue<NKJJCNPGDHF> HKKGECLPMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private TAudioClipId? JBCEJLKPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Stopwatch? MMLDHAPFGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int IACLANALOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GKDMFBPAPPJ? DGMBPEFFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public GBCEOPMAPJH<TAudioClipId> GIEGLNCAMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GBCEOPMAPJH<TAudioClipId> INDLHPKFEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public FLNBPEKPFIH<TAudioClipId, int> FLKLLKDGMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5080DC0", Offset = "0x507FBC0", VA = "0x185080DC0")]
	public HCPAMFEEKGC(GKDMFBPAPPJ FBABCNPBHOI, int OEAPPGPNEJH = 24000)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x507D580", Offset = "0x507C380", VA = "0x18507D580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x507D9B0", Offset = "0x507C7B0", VA = "0x18507D9B0")]
	public void FBFLNCOCDBL(TAudioClipId FMFDAFLDAAK, string PJLPHHNGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x507F970", Offset = "0x507E770", VA = "0x18507F970")]
	public void KIGDDOPIPIC(TAudioClipId FMFDAFLDAAK, IMemoryOwner<byte> PJLPHHNGJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x507DD80", Offset = "0x507CB80", VA = "0x18507DD80")]
	public void GAAGPLELKFC(TAudioClipId FMFDAFLDAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x507FC60", Offset = "0x507EA60", VA = "0x18507FC60")]
	public void MMNPNGDCJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x507FAE0", Offset = "0x507E8E0", VA = "0x18507FAE0")]
	private bool KJPODFKLNOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x507EFB0", Offset = "0x507DDB0", VA = "0x18507EFB0")]
	private void IOOEKAHJJND(float[] CDIFLHLLEBD, int HFBJLOEFBLK, int DAHFJFIDGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x507E030", Offset = "0x507CE30", VA = "0x18507E030")]
	private void GAININFDPMI(byte[] ALPKAMHLIAF, int MCJGICKIGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5080C20", Offset = "0x507FA20", VA = "0x185080C20")]
	private bool ONJBCBNNEKD(NKJJCNPGDHF PFOIAGAEPOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x507D460", Offset = "0x507C260", VA = "0x18507D460")]
	private static void CMOCNGLOLLN(byte[] JICDOIHAMGB, float[] GEDGNONMBOK, int OGEPPDDLCMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x507FBE0", Offset = "0x507E9E0", VA = "0x18507FBE0")]
	private static void MFLGAGBFNHJ(float[] MKPEOGPFEFH, float[] LCAAPKFEJGM, int OGEPPDDLCMD, int GBHDIJIKCIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x507F690", Offset = "0x507E490", VA = "0x18507F690")]
	private static void JHLAPHBOADH(float[] MKPEOGPFEFH, float[] LCAAPKFEJGM, int OGEPPDDLCMD, int GBHDIJIKCIM, float MFHBJGKJHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x507D300", Offset = "0x507C100", VA = "0x18507D300")]
	private static float BFMEDDIBHKG(ReadOnlySpan<float> KANAIIDGHCH, int ENMBFMACLBN, int GBHDIJIKCIM, float MFHBJGKJHHP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BNKPHLCKCDB : GKDMFBPAPPJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AudioSource HOPKCAMEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private DelegatingAudioFilter? COCAMMFKGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GKDMFBPAPPJ.FCEHDBKGMEG? IBELIKJHELA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PMFLBKNAJDA<float[], int, int>? NCLKHCKHOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA93910", Offset = "0xA92710", VA = "0x180A93910", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xE90980", Offset = "0xE8F780", VA = "0x180E90980")]
	public BNKPHLCKCDB(AudioSource FBABCNPBHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x81A26E0", Offset = "0x81A14E0", VA = "0x1881A26E0", Slot = "5")]
	public void IEHCJBEIMLK(GKDMFBPAPPJ.DDFJJPDPIGP EMCGPBHCNMP, GKDMFBPAPPJ.FCEHDBKGMEG AFKPNOJFEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0", Slot = "6")]
	public AudioSource PKFCFJGHMDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x81A2870", Offset = "0x81A1670", VA = "0x1881A2870")]
	private void IOOEKAHJJND(float[] KANAIIDGHCH, int GBHDIJIKCIM, int FMAPGJELDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x81A2570", Offset = "0x81A1370", VA = "0x1881A2570", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GKDMFBPAPPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public delegate bool DDFJJPDPIGP();

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public delegate void FCEHDBKGMEG(float[] KANAIIDGHCH, int GBHDIJIKCIM, int FMAPGJELDND);

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PMFLBKNAJDA<float[], int, int> NCLKHCKHOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEHCJBEIMLK(DDFJJPDPIGP EMCGPBHCNMP, FCEHDBKGMEG AFKPNOJFEPF);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioSource PKFCFJGHMDI();
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
