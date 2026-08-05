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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x833B8D0", Offset = "0x833A6D0", VA = "0x18833B8D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Utilities
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JQTHOFMDRXM : IDisposable
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
			public JQTHOFMDRXM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private object <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x833B950", Offset = "0x833A750", VA = "0x18833B950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x833BD40", Offset = "0x833AB40", VA = "0x18833BD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float SRWWCPTPJYZ = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float UYHJAVEYNBV = 0.7f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const int FKFIBGHMOTT = 48000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const int ITOMQINTDEU = 1;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const int VWAUPHAGGET = 2;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const int UMERHLBLNEN = 96000;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float IVARBBINJQL = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private AudioClip FJTEPHBAMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private AudioSource KIWRZLNXMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private float[] ETMCFRAXLTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int RLDZLFMOFTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int PHWREVMWHRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int HSWQWRVPPXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool IOEIHLPJOUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool NJXQFDOQONB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool ACHDOTPMQGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly bool YCDATGKREJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int SKZZBKDRFJD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool XESJYSWPBEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x28B6670", Offset = "0x28B5470", VA = "0x1828B6670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x833B750", Offset = "0x833A550", VA = "0x18833B750")]
		public JQTHOFMDRXM(AudioSource a, string b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x833B4B0", Offset = "0x833A2B0", VA = "0x18833B4B0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x833B3E0", Offset = "0x833A1E0", VA = "0x18833B3E0")]
		[AsyncStateMachine(typeof(<AsyncUpdate>d__22))]
		public Task NEKOJWHRIGJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x833B500", Offset = "0x833A300", VA = "0x18833B500")]
		public void WHERNCYTQRM(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x833B130", Offset = "0x8339F30", VA = "0x18833B130")]
		private void FSLIONUIRUJ(float[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		private void ODNJRPMRKQQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x833B090", Offset = "0x8339E90", VA = "0x18833B090", Slot = "4")]
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
		private int LUPJWIMUHWF;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event AudioReadEventHandler? FSLIONUIRUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x833AB70", Offset = "0x8339970", VA = "0x18833AB70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x833AC10", Offset = "0x8339A10", VA = "0x18833AC10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x833AAF0", Offset = "0x83398F0", VA = "0x18833AAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x833AA80", Offset = "0x8339880", VA = "0x18833AA80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x833AA50", Offset = "0x8339850", VA = "0x18833AA50")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x833AA30", Offset = "0x8339830", VA = "0x18833AA30")]
		private void FUQEPXTDRVJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public DelegatingAudioFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class GMPMAYPTVUI<a> : IDisposable where a : struct, IEquatable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class AudioPacket : IEquatable<AudioPacket>
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			[CompilerGenerated]
			protected virtual Type DGKVKYIKWWK
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x7136CF0", Offset = "0x7135AF0", VA = "0x187136CF0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public a ZVXCDESMJGV
			{
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xCDB8A0", Offset = "0xCDA6A0", VA = "0x180CDB8A0")]
				[CompilerGenerated]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public IMemoryOwner<byte>? FFDULGKWPQE
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1090C40", Offset = "0x108FA40", VA = "0x181090C40")]
			public AudioPacket(a Id, IMemoryOwner<byte>? Data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x71376F0", Offset = "0x71364F0", VA = "0x1871376F0", Slot = "3")]
			[CompilerGenerated]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7137370", Offset = "0x7136170", VA = "0x187137370", Slot = "6")]
			[CompilerGenerated]
			protected virtual bool TVCBAGTWNOK(StringBuilder a)
			{
				return default(bool);
			}

			[SpecialName]
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1090A60", Offset = "0x108F860", VA = "0x181090A60")]
			[CompilerGenerated]
			public static bool QIDDWXQJPGU(AudioPacket? left, AudioPacket? right)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7136F00", Offset = "0x7135D00", VA = "0x187136F00", Slot = "2")]
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7136890", Offset = "0x7135690", VA = "0x187136890", Slot = "0")]
			[CompilerGenerated]
			public override bool Equals(object? obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7136710", Offset = "0x7135510", VA = "0x187136710", Slot = "7")]
			[CompilerGenerated]
			public virtual bool Equals(AudioPacket? other)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LFNKMNEMLIP : IMemoryOwner<byte>, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly byte[] HCXTARPRYPY;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public Memory<byte> Memory
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0xB611B0", Offset = "0xB5FFB0", VA = "0x180B611B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(Memory<byte>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5455B80", Offset = "0x5454980", VA = "0x185455B80")]
			public LFNKMNEMLIP(byte[] a, int b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5455A40", Offset = "0x5454840", VA = "0x185455A40", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly int OZXXDDPVHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Queue<AudioPacket> SFBHYZGYULL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private a? XDXOWWTVJMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Stopwatch? YBIRCLSEAHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private int HGACWAWWNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private NKHNXJXFDPT? NRCEODWCVEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public OPVLFDQAAOV<a> VMSKBJFLQDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OPVLFDQAAOV<a> VPTNAZEKHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public OPFQNJIHYGU<a, int> LPAIGUYOPBQ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4F90000", Offset = "0x4F8EE00", VA = "0x184F90000")]
		public GMPMAYPTVUI(NKHNXJXFDPT a, int b = 24000)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F89E10", Offset = "0x4F88C10", VA = "0x184F89E10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F270", Offset = "0x4F8E070", VA = "0x184F8F270")]
		public void XPVALJNGPXI(a a, string audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F8ACB0", Offset = "0x4F89AB0", VA = "0x184F8ACB0")]
		public void GHHBIJZNFTN(a a, IMemoryOwner<byte> audioData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4F8F020", Offset = "0x4F8DE20", VA = "0x184F8F020")]
		public void TGMOMNAINZH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4F8C790", Offset = "0x4F8B590", VA = "0x184F8C790")]
		public void IHECOQVVBCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F89D50", Offset = "0x4F88B50", VA = "0x184F89D50")]
		private bool DNGVOYYLYHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4F89F80", Offset = "0x4F88D80", VA = "0x184F89F80")]
		private void FSLIONUIRUJ(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F8CF40", Offset = "0x4F8BD40", VA = "0x184F8CF40")]
		private void KNBNKAJDJFQ(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4F8AFD0", Offset = "0x4F89DD0", VA = "0x184F8AFD0")]
		private bool HLLIEIBDUXM(AudioPacket audioPacket)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4F8EB10", Offset = "0x4F8D910", VA = "0x184F8EB10")]
		private static void QTOOZDIZLHI(byte[] a, float[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4F8EDD0", Offset = "0x4F8DBD0", VA = "0x184F8EDD0")]
		private static void SAHWXXEKRDH(float[] a, float[] b, int c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4F8E810", Offset = "0x4F8D610", VA = "0x184F8E810")]
		private static void QKYXKWHSZZR(float[] a, float[] b, int c, int d, float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4F8EC70", Offset = "0x4F8DA70", VA = "0x184F8EC70")]
		private static float QXPDEZVGLLR(ReadOnlySpan<float> a, int b, int c, float d)
		{
			return default(float);
		}
	}
}
namespace RecRoom.Audio.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class JGSPHVQKQCS : NKHNXJXFDPT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AudioSource RZPHWMXUUSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DelegatingAudioFilter? FRQIDNKCXZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NKHNXJXFDPT.OnAudioReadEventHandler? AZIFSFPNXTA;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OPKXKQCFHSD<float[], int, int>? MBZZHLPSMNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC59500", Offset = "0xC58300", VA = "0x180C59500")]
		public JGSPHVQKQCS(AudioSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x833AEB0", Offset = "0x8339CB0", VA = "0x18833AEB0", Slot = "5")]
		public void Initialize(NKHNXJXFDPT.HasPendingAudioDataDelegate hasPendingAudio, NKHNXJXFDPT.OnAudioReadEventHandler onAudioRead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
		public AudioSource LHEXRJSHBQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x833AE10", Offset = "0x8339C10", VA = "0x18833AE10")]
		private void FSLIONUIRUJ(float[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x833ACB0", Offset = "0x8339AB0", VA = "0x18833ACB0", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface NKHNXJXFDPT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate bool HasPendingAudioDataDelegate();

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void OnAudioReadEventHandler(float[] data, int channels, int sampleRate);

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		OPKXKQCFHSD<float[], int, int> MBZZHLPSMNT
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
		AudioSource LHEXRJSHBQK();
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
