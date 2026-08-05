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
using RecRoom.Audio.Utilities;
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9804240", Offset = "0x9803240", VA = "0x189804240")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class WDYEIQJAMVE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private struct <AsyncUpdate>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public WDYEIQJAMVE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x98046A0", Offset = "0x98036A0", VA = "0x1898046A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9804A90", Offset = "0x9803A90", VA = "0x189804A90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float SQHSCQSOSND = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float WLJMUZFJLBN = 0.7f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int CPEJCKEMJSJ = 48000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int WPJFOGYQJQE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int NRBSZCJAHZF = 2;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int YXOTRPFUJWJ = 96000;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float XCTXIFFJYJN = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private AudioClip NVLGZCBJKHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private AudioSource GWGMVZOQVVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float[] UFUZBTMGTKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int ICQUGFRYKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int JVGDAAKMXWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ZEJLUGSNRGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool AIIFUWDMYIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool CGSBRIXICLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HTEMMIQRGTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool BWWYQHJZXUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int DAWXCKCAQGV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool WCXXWWPBRUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2B10880", Offset = "0x2B0F880", VA = "0x182B10880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98051B0", Offset = "0x98041B0", VA = "0x1898051B0")]
		public WDYEIQJAMVE(AudioSource a, string b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9805160", Offset = "0x9804160", VA = "0x189805160")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9805090", Offset = "0x9804090", VA = "0x189805090")]
		[AsyncStateMachine(typeof(<AsyncUpdate>d__22))]
		public Task TZNUMIYNNGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9804B90", Offset = "0x9803B90", VA = "0x189804B90")]
		public void MVIZKCBYTGO(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9804DE0", Offset = "0x9803DE0", VA = "0x189804DE0")]
		private void MXNFUCQZGEV(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		private void LXRGJZLXVGQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9804AF0", Offset = "0x9803AF0", VA = "0x189804AF0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Audio
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DelegatingAudioFilter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public delegate void AudioReadEventHandler(float[] data, int channels, int sampleRate);

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int LNYPPYOTFBP;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AudioReadEventHandler? MXNFUCQZGEV
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9804100", Offset = "0x9803100", VA = "0x189804100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x98041A0", Offset = "0x98031A0", VA = "0x1898041A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9804080", Offset = "0x9803080", VA = "0x189804080")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9804010", Offset = "0x9803010", VA = "0x189804010")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9803FE0", Offset = "0x9802FE0", VA = "0x189803FE0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9803FC0", Offset = "0x9802FC0", VA = "0x189803FC0")]
		private void JOFRTEPKLUL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public DelegatingAudioFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class IGMETQAKOKY<a> : IDisposable where a : struct, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class AudioPacket : IEquatable<AudioPacket>
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			[CompilerGenerated]
			protected virtual Type OPWBCPNCURM
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x4F04A60", Offset = "0x4F03A60", VA = "0x184F04A60", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public a JQCTFOCWOYF
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xF1C290", Offset = "0xF1B290", VA = "0x180F1C290")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IMemoryOwner<byte>? HBLTVDNEEXS
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12D5200", Offset = "0x12D4200", VA = "0x1812D5200")]
			public AudioPacket(a Id, IMemoryOwner<byte>? Data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4F04B90", Offset = "0x4F03B90", VA = "0x184F04B90", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4F04F90", Offset = "0x4F03F90", VA = "0x184F04F90", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool XJINPLHNWWW(StringBuilder a)
			{
				return default(bool);
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x12D4F90", Offset = "0x12D3F90", VA = "0x1812D4F90")]
			[CompilerGenerated]
			public static bool IQJYWSDTJLC(AudioPacket? left, AudioPacket? right)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4F04640", Offset = "0x4F03640", VA = "0x184F04640", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4F045B0", Offset = "0x4F035B0", VA = "0x184F045B0", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4F041C0", Offset = "0x4F031C0", VA = "0x184F041C0", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(AudioPacket? other)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class BVCHBJCMCVZ : IMemoryOwner<byte>, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly byte[] MKPYTWKWXJY;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Memory<byte> Memory
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Memory<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4FFB890", Offset = "0x4FFA890", VA = "0x184FFB890")]
			public BVCHBJCMCVZ(byte[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4FFB750", Offset = "0x4FFA750", VA = "0x184FFB750", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int NBQGCJJGOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Queue<AudioPacket> KTHKENYLEQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private a? QYQFEJXLOZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Stopwatch? YAYNVVJATDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int XRUYAOLMLET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private DETNQPUJHTT? JZEMCZLXJOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public DRWWZAXJWQZ<a> SDHCLALWGVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DRWWZAXJWQZ<a> EASXPAEXBJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public DRHCHGPRUIY<a, int> JHPOTSYYSQG;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x666D2D0", Offset = "0x666C2D0", VA = "0x18666D2D0")]
		public IGMETQAKOKY(DETNQPUJHTT a, int b = 24000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x66675E0", Offset = "0x66665E0", VA = "0x1866675E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x666C7B0", Offset = "0x666B7B0", VA = "0x18666C7B0")]
		public void YWQEJJTIZEW(a a, string audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x666C390", Offset = "0x666B390", VA = "0x18666C390")]
		public void TGMKWSVUNSX(a a, IMemoryOwner<byte> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66694A0", Offset = "0x66684A0", VA = "0x1866694A0")]
		public void KVQKVQDUVWN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6667790", Offset = "0x6666790", VA = "0x186667790")]
		public void KNLTDCNPCXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x666C6F0", Offset = "0x666B6F0", VA = "0x18666C6F0")]
		private bool WMFPTRRAFVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x666B690", Offset = "0x666A690", VA = "0x18666B690")]
		private void MXNFUCQZGEV(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x666A2C0", Offset = "0x66692C0", VA = "0x18666A2C0")]
		private void MCJEUARDLAC(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x666BD00", Offset = "0x666AD00", VA = "0x18666BD00")]
		private bool RYTSIYNKUSO(AudioPacket audioPacket)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x66676E0", Offset = "0x66666E0", VA = "0x1866676E0")]
		private static void FMAMAFNKPPY(byte[] a, float[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x666C4D0", Offset = "0x666B4D0", VA = "0x18666C4D0")]
		private static void TMUBEXFOWCV(float[] a, float[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x66670F0", Offset = "0x66660F0", VA = "0x1866670F0")]
		private static void CCZOBHIELZB(float[] a, float[] b, int c, int d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x666BBA0", Offset = "0x666ABA0", VA = "0x18666BBA0")]
		private static float ONSEAXFYMID(ReadOnlySpan<float> a, int b, int c, float d)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Audio.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class OKPRLNMPTOO : DETNQPUJHTT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AudioSource ALPGXLBAMQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DelegatingAudioFilter? YWJADCCDWGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private DETNQPUJHTT.OnAudioReadEventHandler? TPPKQUEWDQO;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DRMJENJPDUH<float[], int, int>? OHEEKLEPHIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEA2640", Offset = "0xEA1640", VA = "0x180EA2640")]
		public OKPRLNMPTOO(AudioSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9804420", Offset = "0x9803420", VA = "0x189804420", Slot = "5")]
		public void Initialize(DETNQPUJHTT.HasPendingAudioDataDelegate hasPendingAudio, DETNQPUJHTT.OnAudioReadEventHandler onAudioRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
		public AudioSource WCDUAUWZWMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9804600", Offset = "0x9803600", VA = "0x189804600")]
		private void MXNFUCQZGEV(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x98042C0", Offset = "0x98032C0", VA = "0x1898042C0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface DETNQPUJHTT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate bool HasPendingAudioDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void OnAudioReadEventHandler(float[] data, int channels, int sampleRate);

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		DRMJENJPDUH<float[], int, int> OHEEKLEPHIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Initialize(HasPendingAudioDataDelegate hasPendingAudio, OnAudioReadEventHandler onAudioRead);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		AudioSource WCDUAUWZWMG();
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
