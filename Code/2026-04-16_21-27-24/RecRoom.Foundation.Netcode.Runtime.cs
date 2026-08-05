using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Netcode;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace RecRoom.Foundation.Bitstream
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public ref struct BitReader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Unity.Netcode.BitReader reader;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C370", Offset = "0x5A5B170", VA = "0x185A5C370")]
		public BitReader(Unity.Netcode.BitReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9868DB0", Offset = "0x9867BB0", VA = "0x189868DB0")]
		public void VXIGYTRTUBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9868D30", Offset = "0x9867B30", VA = "0x189868D30")]
		public void FQZHOWYVMPG([Out] bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9868D90", Offset = "0x9867B90", VA = "0x189868D90")]
		public void PEEVVQQGQYV([Out] ulong a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9868DA0", Offset = "0x9867BA0", VA = "0x189868DA0")]
		public void PEEVVQQGQYV([Out] byte a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KWMTDHEQGTL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9869840", Offset = "0x9868640", VA = "0x189869840")]
		public static bool DMRPOXCKUAJ(this BitReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9869890", Offset = "0x9868690", VA = "0x189869890")]
		public static uint JOSGKCYHLXD(this BitReader a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98699E0", Offset = "0x98687E0", VA = "0x1898699E0")]
		public static uint ZVCSQBZGEJE(this BitReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9869920", Offset = "0x9868720", VA = "0x189869920")]
		public static ulong QIBQPIPKHNF(this BitReader a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XYOUGSMDOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x986A200", Offset = "0x9869000", VA = "0x18986A200")]
		public static void ZCNFUAYRIHV(this BitWriter a, uint b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9869C70", Offset = "0x9868A70", VA = "0x189869C70")]
		public static uint MZLAFNJCNLM(this BitReader a, bool b = false)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BKBGBDIOKPW
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int[] EIJRHUFPAQN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9868BF0", Offset = "0x98679F0", VA = "0x189868BF0")]
		public static int OZIILGIDOQX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x867DB60", Offset = "0x867C960", VA = "0x18867DB60")]
		public static int CNEZZGHCVEI(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96F33B0", Offset = "0x96F21B0", VA = "0x1896F33B0")]
		public static long JYLTKBUHMCZ(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86A0AA0", Offset = "0x869F8A0", VA = "0x1886A0AA0")]
		public static uint BRCYBBLRBKM(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96F3650", Offset = "0x96F2450", VA = "0x1896F3650")]
		public static ulong ICRHKAIRBUJ(long a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public ref struct BitWriter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Unity.Netcode.BitWriter writer;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5A5C370", Offset = "0x5A5B170", VA = "0x185A5C370")]
		public BitWriter(Unity.Netcode.BitWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9868DC0", Offset = "0x9867BC0", VA = "0x189868DC0")]
		public void VXIGYTRTUBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9868DE0", Offset = "0x9867BE0", VA = "0x189868DE0")]
		public void WPIWTZQGBHB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9868DD0", Offset = "0x9867BD0", VA = "0x189868DD0")]
		public void WJUSEHRXXRK(ulong a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class DVBNVCMMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9868E40", Offset = "0x9867C40", VA = "0x189868E40")]
		public static ReadOnlySpan<byte> GUOUWQVGAHZ(this FastBufferWriter a)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9868F20", Offset = "0x9867D20", VA = "0x189868F20")]
		public static NativeArray<byte> OPEOQZMPNPG(this FastBufferWriter a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9868DE0", Offset = "0x9867BE0", VA = "0x189868DE0")]
		public static void PRFKKNJHBCA(this BitWriter a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98690A0", Offset = "0x9867EA0", VA = "0x1898690A0")]
		public static void TCTXZXJIXOI(this BitWriter a, uint b, uint c, uint d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98691B0", Offset = "0x9867FB0", VA = "0x1898691B0")]
		public static void YZTAZOTNXAB(this BitWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9869140", Offset = "0x9867F40", VA = "0x189869140")]
		public static void TLJMXKSEGAS(this BitWriter a, ulong b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FastBufferReader : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public Unity.Netcode.FastBufferReader reader;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5A667A0", Offset = "0x5A655A0", VA = "0x185A667A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9869350", Offset = "0x9868150", VA = "0x189869350")]
		public FastBufferReader(NativeArray<byte> src, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9869220", Offset = "0x9868020", VA = "0x189869220")]
		public bool AZAFAXRXEYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9869320", Offset = "0x9868120", VA = "0x189869320")]
		public BitReader TPGAKQATMXJ()
		{
			return default(BitReader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x98692F0", Offset = "0x98680F0", VA = "0x1898692F0")]
		public void HZUHYQXJVSD([Out] byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9869260", Offset = "0x9868060", VA = "0x189869260")]
		public void EIUZOSTGJRS(NativeArray<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AA7010", Offset = "0x3AA5E10", VA = "0x183AA7010")]
		public unsafe void EIUZOSTGJRS(byte* a, int b, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD8F0", Offset = "0x3AAC6F0", VA = "0x183AAD8F0")]
		public void LMUZZGHIMKH<T>([Out] T a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFAF0", Offset = "0x3AAE8F0", VA = "0x183AAFAF0")]
		public void YHSBHLIZZJS<T>([Out] T a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AAD950", Offset = "0x3AAC750", VA = "0x183AAD950")]
		public void LMUZZGHIMKH<T>(NativeArray<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AADA40", Offset = "0x3AAC840", VA = "0x183AADA40")]
		public void LMUZZGHIMKH<T>(NativeList<T> a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9869250", Offset = "0x9868050", VA = "0x189869250", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class IZJPIFWRMHS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98696C0", Offset = "0x98684C0", VA = "0x1898696C0")]
		public static int JYDXORXYWLF(this FastBufferReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9869720", Offset = "0x9868520", VA = "0x189869720")]
		public static long LRXVAYWBLQI(this FastBufferReader a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9869830", Offset = "0x9868630", VA = "0x189869830")]
		public static uint ZVCSQBZGEJE(this FastBufferReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9869780", Offset = "0x9868580", VA = "0x189869780")]
		public static ulong QIBQPIPKHNF(this FastBufferReader a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FastBufferWriter : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Unity.Netcode.FastBufferWriter writer;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9869620", Offset = "0x9868420", VA = "0x189869620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9869680", Offset = "0x9868480", VA = "0x189869680")]
		public FastBufferWriter(int capacity, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98693A0", Offset = "0x98681A0", VA = "0x1898693A0")]
		public bool AZAFAXRXEYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9869520", Offset = "0x9868320", VA = "0x189869520")]
		public BitWriter TPGAKQATMXJ()
		{
			return default(BitWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9869400", Offset = "0x9868200", VA = "0x189869400", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9869450", Offset = "0x9868250", VA = "0x189869450")]
		public unsafe byte* OMOMUNPPJQB()
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98694B0", Offset = "0x98682B0", VA = "0x1898694B0")]
		public void PHVJALDVLQW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9869590", Offset = "0x9868390", VA = "0x189869590")]
		public void WEPJPVJZGCH(NativeArray<byte> a, int b = -1, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFF90", Offset = "0x3AAED90", VA = "0x183AAFF90")]
		public void JTDREBVHTVK<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFB40", Offset = "0x3AAE940", VA = "0x183AAFB40")]
		public void DUILBZLLBHX<T>([In] T value, int a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3AAFFE0", Offset = "0x3AAEDE0", VA = "0x183AAFFE0")]
		public void JTDREBVHTVK<T>(NativeList<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AB00F0", Offset = "0x3AAEEF0", VA = "0x183AB00F0")]
		public void JTDREBVHTVK<T>(NativeArray<T> a) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NXLPOEQSEUM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9869B10", Offset = "0x9868910", VA = "0x189869B10")]
		public static void FYNASIKQSMS(this FastBufferWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9869AA0", Offset = "0x98688A0", VA = "0x189869AA0")]
		public static void CMRERJZCGKD(this FastBufferWriter a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9869C60", Offset = "0x9868A60", VA = "0x189869C60")]
		public static void YZTAZOTNXAB(this FastBufferWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9869B70", Offset = "0x9868970", VA = "0x189869B70")]
		public static void TLJMXKSEGAS(this FastBufferWriter a, ulong b)
		{
		}
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
