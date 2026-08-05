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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x8031500", Offset = "0x8030900", VA = "0x188031500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class VYUVXXSAWIY : IDisposable
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
			public VYUVXXSAWIY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8031580", Offset = "0x8030980", VA = "0x188031580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8031970", Offset = "0x8030D70", VA = "0x188031970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float QQTUAOYZOML = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float YMPHEFWJQZT = 0.7f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int DDTQGLYQTFV = 48000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int XPQDUUNHZWK = 1;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int QXKSUUGKHMJ = 2;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int LNDDRYUWTBZ = 96000;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float EIKRCDOWBIR = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private AudioClip AIJMIZFIXDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private AudioSource CSJPEOJJMMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float[] VEMUBSMKAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int YVCZAFAHVBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int CSDWCYVTDBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int TKFKKXUOWGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool GJUVBNQFYNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool LCHZCDMDUVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool EGMKQMOUOQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool RNJMGPCQTUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int RPEIASVYUNF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool IZDLVKUEZEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x283B140", Offset = "0x283A540", VA = "0x18283B140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8032090", Offset = "0x8031490", VA = "0x188032090")]
		public VYUVXXSAWIY(AudioSource a, string b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8031CC0", Offset = "0x80310C0", VA = "0x188031CC0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8031D10", Offset = "0x8031110", VA = "0x188031D10")]
		[AsyncStateMachine(typeof(<AsyncUpdate>d__22))]
		public Task YHDLOIQORPV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8031A70", Offset = "0x8030E70", VA = "0x188031A70")]
		public void FKKNYVCHMAM(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8031DE0", Offset = "0x80311E0", VA = "0x188031DE0")]
		private void ZBLYCIHDFDB(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		private void VXOEADCYKJA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80319D0", Offset = "0x8030DD0", VA = "0x1880319D0", Slot = "4")]
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
		private int ZGWTQMNPYOT;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AudioReadEventHandler? ZBLYCIHDFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80313C0", Offset = "0x80307C0", VA = "0x1880313C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8031460", Offset = "0x8030860", VA = "0x188031460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8031340", Offset = "0x8030740", VA = "0x188031340")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80312D0", Offset = "0x80306D0", VA = "0x1880312D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80312A0", Offset = "0x80306A0", VA = "0x1880312A0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8031280", Offset = "0x8030680", VA = "0x188031280")]
		private void ASTLQZQSUPP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
		public DelegatingAudioFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class NZUYEDDHJLI<a> : IDisposable where a : struct, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class AudioPacket : IEquatable<AudioPacket>
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			[CompilerGenerated]
			protected virtual Type DGZTNXENXMY
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x6DA6440", Offset = "0x6DA5840", VA = "0x186DA6440", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public a KVDFRQPXLVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xC28720", Offset = "0xC27B20", VA = "0x180C28720")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IMemoryOwner<byte>? OEEWMRVQBKK
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xFF2110", Offset = "0xFF1510", VA = "0x180FF2110")]
			public AudioPacket(a Id, IMemoryOwner<byte>? Data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6DA6570", Offset = "0x6DA5970", VA = "0x186DA6570", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6DA57A0", Offset = "0x6DA4BA0", VA = "0x186DA57A0", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool ANVHGNUJOYA(StringBuilder a)
			{
				return default(bool);
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xFF1FD0", Offset = "0xFF13D0", VA = "0x180FF1FD0")]
			[CompilerGenerated]
			public static bool NAQFJJXEQSO(AudioPacket? left, AudioPacket? right)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DA6310", Offset = "0x6DA5710", VA = "0x186DA6310", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6DA5A80", Offset = "0x6DA4E80", VA = "0x186DA5A80", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DA5EC0", Offset = "0x6DA52C0", VA = "0x186DA5EC0", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(AudioPacket? other)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ADCERSEDMPX : IMemoryOwner<byte>, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly byte[] LVCKMZJWUOY;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Memory<byte> Memory
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Memory<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x53A1290", Offset = "0x53A0690", VA = "0x1853A1290")]
			public ADCERSEDMPX(byte[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x53A1090", Offset = "0x53A0490", VA = "0x1853A1090", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int CMEZOYJMZJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Queue<AudioPacket> FRFEGWJGVLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private a? VJSJLFDUEHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Stopwatch? LVQYKQIERXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int LLTCGWHQYNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JXWRIBKZRIH? FOCAUIJDSLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JQSJODDDNWT<a> WWAPOVNLQED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JQSJODDDNWT<a> KMDMXZYRQHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JQXQLJXAXIC<a, int> JAEIWKSGAAE;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x586B870", Offset = "0x586AC70", VA = "0x18586B870")]
		public NZUYEDDHJLI(JXWRIBKZRIH a, int b = 24000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58659D0", Offset = "0x5864DD0", VA = "0x1858659D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5865AB0", Offset = "0x5864EB0", VA = "0x185865AB0")]
		public void EZAOICYFTYA(a a, string audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x586A390", Offset = "0x5869790", VA = "0x18586A390")]
		public void YBDEYEZIBAJ(a a, IMemoryOwner<byte> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x58665A0", Offset = "0x58659A0", VA = "0x1858665A0")]
		public void FLTHQCELICT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5867000", Offset = "0x5866400", VA = "0x185867000")]
		public void GWSWSFAQKGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5865880", Offset = "0x5864C80", VA = "0x185865880")]
		private bool DOOFPDDVIQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x586AAF0", Offset = "0x5869EF0", VA = "0x18586AAF0")]
		private void ZBLYCIHDFDB(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5869740", Offset = "0x5868B40", VA = "0x185869740")]
		private void QDGWUQYARFO(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x58654E0", Offset = "0x58648E0", VA = "0x1858654E0")]
		private bool AQHLMXMGMAY(AudioPacket audioPacket)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5865640", Offset = "0x5864A40", VA = "0x185865640")]
		private static void DJFOKBCTUPW(byte[] a, float[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5869D80", Offset = "0x5869180", VA = "0x185869D80")]
		private static void THJDDPNEPGD(float[] a, float[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5869E00", Offset = "0x5869200", VA = "0x185869E00")]
		private static void VCKFEPBLIYZ(float[] a, float[] b, int c, int d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5868630", Offset = "0x5867A30", VA = "0x185868630")]
		private static float KSVVAWXJJDD(ReadOnlySpan<float> a, int b, int c, float d)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Audio.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DSQZGBHPNDG : JXWRIBKZRIH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AudioSource ELVTPXVHGFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DelegatingAudioFilter? RJRNXTXJQVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private JXWRIBKZRIH.OnAudioReadEventHandler? JFUGACKFEEQ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public JRCXIQQYGTL<float[], int, int>? TFCBVBWLUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xBCF630", Offset = "0xBCEA30", VA = "0x180BCF630")]
		public DSQZGBHPNDG(AudioSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8031000", Offset = "0x8030400", VA = "0x188031000", Slot = "5")]
		public void Initialize(JXWRIBKZRIH.HasPendingAudioDataDelegate hasPendingAudio, JXWRIBKZRIH.OnAudioReadEventHandler onAudioRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
		public AudioSource PHOWXSOWVEU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80311E0", Offset = "0x80305E0", VA = "0x1880311E0")]
		private void ZBLYCIHDFDB(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8030EA0", Offset = "0x80302A0", VA = "0x188030EA0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface JXWRIBKZRIH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate bool HasPendingAudioDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void OnAudioReadEventHandler(float[] data, int channels, int sampleRate);

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		JRCXIQQYGTL<float[], int, int> TFCBVBWLUVJ
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
		AudioSource PHOWXSOWVEU();
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
