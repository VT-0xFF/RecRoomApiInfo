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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x96615E0", Offset = "0x965FFE0", VA = "0x1896615E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
			[Cpp2IlInjected.Address(RVA = "0x9661A40", Offset = "0x9660440", VA = "0x189661A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9661E30", Offset = "0x9660830", VA = "0x189661E30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x2AF9520", Offset = "0x2AF7F20", VA = "0x182AF9520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9662550", Offset = "0x9660F50", VA = "0x189662550")]
		public WDYEIQJAMVE(AudioSource a, string b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9662500", Offset = "0x9660F00", VA = "0x189662500")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9662430", Offset = "0x9660E30", VA = "0x189662430")]
		[AsyncStateMachine(typeof(<AsyncUpdate>d__22))]
		public Task TZNUMIYNNGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9661F30", Offset = "0x9660930", VA = "0x189661F30")]
		public void MVIZKCBYTGO(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9662180", Offset = "0x9660B80", VA = "0x189662180")]
		private void MXNFUCQZGEV(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void LXRGJZLXVGQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9661E90", Offset = "0x9660890", VA = "0x189661E90", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x96614A0", Offset = "0x965FEA0", VA = "0x1896614A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9661540", Offset = "0x965FF40", VA = "0x189661540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9661420", Offset = "0x965FE20", VA = "0x189661420")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96613B0", Offset = "0x965FDB0", VA = "0x1896613B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9661380", Offset = "0x965FD80", VA = "0x189661380")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9661360", Offset = "0x965FD60", VA = "0x189661360")]
		private void JOFRTEPKLUL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEE920", VA = "0x180CEFF20")]
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
				[Cpp2IlInjected.Address(RVA = "0x4EBDAA0", Offset = "0x4EBC4A0", VA = "0x184EBDAA0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0xF00A10", Offset = "0xEFF410", VA = "0x180F00A10")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12B9090", Offset = "0x12B7A90", VA = "0x1812B9090")]
			public AudioPacket(a Id, IMemoryOwner<byte>? Data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDBD0", Offset = "0x4EBC5D0", VA = "0x184EBDBD0", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4EBDFC0", Offset = "0x4EBC9C0", VA = "0x184EBDFC0", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool XJINPLHNWWW(StringBuilder a)
			{
				return default(bool);
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x12B8E20", Offset = "0x12B7820", VA = "0x1812B8E20")]
			[CompilerGenerated]
			public static bool IQJYWSDTJLC(AudioPacket? left, AudioPacket? right)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4EBD690", Offset = "0x4EBC090", VA = "0x184EBD690", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4EBD600", Offset = "0x4EBC000", VA = "0x184EBD600", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4EBD240", Offset = "0x4EBBC40", VA = "0x184EBD240", Slot = "7")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87230", VA = "0x180D88830", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Memory<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4FAFFB0", Offset = "0x4FAE9B0", VA = "0x184FAFFB0")]
			public BVCHBJCMCVZ(byte[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4FAFE70", Offset = "0x4FAE870", VA = "0x184FAFE70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6594E40", Offset = "0x6593840", VA = "0x186594E40")]
		public IGMETQAKOKY(DETNQPUJHTT a, int b = 24000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x658F3A0", Offset = "0x658DDA0", VA = "0x18658F3A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6594350", Offset = "0x6592D50", VA = "0x186594350")]
		public void YWQEJJTIZEW(a a, string audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6593F50", Offset = "0x6592950", VA = "0x186593F50")]
		public void TGMKWSVUNSX(a a, IMemoryOwner<byte> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6591180", Offset = "0x658FB80", VA = "0x186591180")]
		public void KVQKVQDUVWN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x658F550", Offset = "0x658DF50", VA = "0x18658F550")]
		public void KNLTDCNPCXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6594290", Offset = "0x6592C90", VA = "0x186594290")]
		private bool WMFPTRRAFVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6593290", Offset = "0x6591C90", VA = "0x186593290")]
		private void MXNFUCQZGEV(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6591F20", Offset = "0x6590920", VA = "0x186591F20")]
		private void MCJEUARDLAC(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6593900", Offset = "0x6592300", VA = "0x186593900")]
		private bool RYTSIYNKUSO(AudioPacket audioPacket)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x658F4A0", Offset = "0x658DEA0", VA = "0x18658F4A0")]
		private static void FMAMAFNKPPY(byte[] a, float[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6594080", Offset = "0x6592A80", VA = "0x186594080")]
		private static void TMUBEXFOWCV(float[] a, float[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x658EEC0", Offset = "0x658D8C0", VA = "0x18658EEC0")]
		private static void CCZOBHIELZB(float[] a, float[] b, int c, int d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x65937A0", Offset = "0x65921A0", VA = "0x1865937A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE86EB0", Offset = "0xE858B0", VA = "0x180E86EB0")]
		public OKPRLNMPTOO(AudioSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96617C0", Offset = "0x96601C0", VA = "0x1896617C0", Slot = "5")]
		public void Initialize(DETNQPUJHTT.HasPendingAudioDataDelegate hasPendingAudio, DETNQPUJHTT.OnAudioReadEventHandler onAudioRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
		public AudioSource WCDUAUWZWMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x96619A0", Offset = "0x96603A0", VA = "0x1896619A0")]
		private void MXNFUCQZGEV(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9661660", Offset = "0x9660060", VA = "0x189661660", Slot = "7")]
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
