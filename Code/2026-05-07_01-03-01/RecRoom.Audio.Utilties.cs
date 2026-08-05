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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9646190", Offset = "0x9644B90", VA = "0x189646190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class GENVHRITKYS : IDisposable
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
			public GENVHRITKYS <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9646210", Offset = "0x9644C10", VA = "0x189646210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9646600", Offset = "0x9645000", VA = "0x189646600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float WOJDHWFIACN = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DHNNPEBUFSP = 0.7f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int TIWUYCRNRQJ = 48000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int QICCGZXFYEM = 1;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int OALVJWDNMAH = 2;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int UGNMALBWSXP = 96000;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float VOZQYEKVZCD = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private AudioClip UQOZORGRAZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private AudioSource JMXOBFHKRUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float[] HQNRBHWBXWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int RQPIGIXZBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int YMZCMLFGACX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int YPSTKIZWWLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool VHVXNZTOENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool MEPCJQTBNZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool CTKGLJIILTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool VXTCBCDDTJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int KADJAVHMZMB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool XFQYJBAHZNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x2AF6E90", Offset = "0x2AF5890", VA = "0x182AF6E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9645C30", Offset = "0x9644630", VA = "0x189645C30")]
		public GENVHRITKYS(AudioSource a, string b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9645BE0", Offset = "0x96445E0", VA = "0x189645BE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96458C0", Offset = "0x96442C0", VA = "0x1896458C0")]
		[AsyncStateMachine(typeof(<AsyncUpdate>d__22))]
		public Task FIUPEYJKRSB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9645990", Offset = "0x9644390", VA = "0x189645990")]
		public void GXWPCWPQLEG(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9645610", Offset = "0x9644010", VA = "0x189645610")]
		private void EUCCENFHGDD(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		private void XCGSXEOZJSE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9645570", Offset = "0x9643F70", VA = "0x189645570", Slot = "4")]
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
		private int NBNUNOCHASF;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AudioReadEventHandler? EUCCENFHGDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9645430", Offset = "0x9643E30", VA = "0x189645430")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x96454D0", Offset = "0x9643ED0", VA = "0x1896454D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9645390", Offset = "0x9643D90", VA = "0x189645390")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9645320", Offset = "0x9643D20", VA = "0x189645320")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96452F0", Offset = "0x9643CF0", VA = "0x1896452F0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9645410", Offset = "0x9643E10", VA = "0x189645410")]
		private void SKOKTSKDXCL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
		public DelegatingAudioFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class QLOJCHYVZDO<a> : IDisposable where a : struct, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class AudioPacket : IEquatable<AudioPacket>
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			[CompilerGenerated]
			protected virtual Type EDIJWAUHDYG
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x4E9DD10", Offset = "0x4E9C710", VA = "0x184E9DD10", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public a LVYPECRPQWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xEF88F0", Offset = "0xEF72F0", VA = "0x180EF88F0")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IMemoryOwner<byte>? JYJRJZUXYDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12B0970", Offset = "0x12AF370", VA = "0x1812B0970")]
			public AudioPacket(a Id, IMemoryOwner<byte>? Data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4E9DE40", Offset = "0x4E9C840", VA = "0x184E9DE40", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D800", Offset = "0x4E9C200", VA = "0x184E9D800", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool FXBDBBFMWCK(StringBuilder a)
			{
				return default(bool);
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x12B0800", Offset = "0x12AF200", VA = "0x1812B0800")]
			[CompilerGenerated]
			public static bool OTUOIXXRZSY(AudioPacket? left, AudioPacket? right)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4E9DBB0", Offset = "0x4E9C5B0", VA = "0x184E9DBB0", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4E9CF60", Offset = "0x4E9B960", VA = "0x184E9CF60", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4E9D3B0", Offset = "0x4E9BDB0", VA = "0x184E9D3B0", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(AudioPacket? other)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class KFAOBXPVZIT : IMemoryOwner<byte>, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly byte[] OARPHUDUKDE;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Memory<byte> Memory
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xD6A2B0", Offset = "0xD68CB0", VA = "0x180D6A2B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Memory<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6839450", Offset = "0x6837E50", VA = "0x186839450")]
			public KFAOBXPVZIT(byte[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6839150", Offset = "0x6837B50", VA = "0x186839150", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int WMWMWCIHAUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Queue<AudioPacket> AQCOAZQQDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private a? NNKKQYRGRIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Stopwatch? HSABGTMWQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int PQNQVHPYXJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private LGYDDGKNUYJ? VBJEIKCEWUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public DQCNOGDGYBL<a> MOZLSONBLXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DQCNOGDGYBL<a> WWVVDNXXMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public DPMSWLVOVTK<a, int> JLVVECDULRU;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x764A360", Offset = "0x7648D60", VA = "0x18764A360")]
		public QLOJCHYVZDO(LGYDDGKNUYJ a, int b = 24000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7646350", Offset = "0x7644D50", VA = "0x187646350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7647530", Offset = "0x7645F30", VA = "0x187647530")]
		public void PQRGHLCYGVU(a a, string audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7649880", Offset = "0x7648280", VA = "0x187649880")]
		public void XVLKBTZIXGD(a a, IMemoryOwner<byte> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7644140", Offset = "0x7642B40", VA = "0x187644140")]
		public void ANOSPTWIJQV(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7644790", Offset = "0x7643190", VA = "0x187644790")]
		public void DKHPFHGDIEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7644540", Offset = "0x7642F40", VA = "0x187644540")]
		private bool AWBGFRKIZTE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7646C40", Offset = "0x7645640", VA = "0x187646C40")]
		private void EUCCENFHGDD(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7648C90", Offset = "0x7647690", VA = "0x187648C90")]
		private void RTNLAIHJDCC(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7647E50", Offset = "0x7646850", VA = "0x187647E50")]
		private bool QWMKRMDMPEC(AudioPacket audioPacket)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x76470A0", Offset = "0x7645AA0", VA = "0x1876470A0")]
		private static void KWQEAYNIDPM(byte[] a, float[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7646430", Offset = "0x7644E30", VA = "0x187646430")]
		private static void ESAXANPWZRX(float[] a, float[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7649E10", Offset = "0x7648810", VA = "0x187649E10")]
		private static void ZWEGMMMNSCP(float[] a, float[] b, int c, int d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7647CF0", Offset = "0x76466F0", VA = "0x187647CF0")]
		private static float QILXWMRYZJJ(ReadOnlySpan<float> a, int b, int c, float d)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Audio.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MGKRBLIRYBA : LGYDDGKNUYJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AudioSource LHTMLZQUJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DelegatingAudioFilter? BHWOYUPMYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LGYDDGKNUYJ.OnAudioReadEventHandler? RRPJIQMDDAK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DPRZTSPMFET<float[], int, int>? VPVZAOKWTOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE9C2B0", Offset = "0xE9ACB0", VA = "0x180E9C2B0")]
		public MGKRBLIRYBA(AudioSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9645FB0", Offset = "0x96449B0", VA = "0x189645FB0", Slot = "5")]
		public void Initialize(LGYDDGKNUYJ.HasPendingAudioDataDelegate hasPendingAudio, LGYDDGKNUYJ.OnAudioReadEventHandler onAudioRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
		public AudioSource OVZEEMTSSIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9645F10", Offset = "0x9644910", VA = "0x189645F10")]
		private void EUCCENFHGDD(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9645DB0", Offset = "0x96447B0", VA = "0x189645DB0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface LGYDDGKNUYJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate bool HasPendingAudioDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void OnAudioReadEventHandler(float[] data, int channels, int sampleRate);

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		DPRZTSPMFET<float[], int, int> VPVZAOKWTOZ
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
		AudioSource OVZEEMTSSIK();
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
